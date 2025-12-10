using System;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public event Action<int> OnEnemyTakeDamage;
    public event Action OnEnemyDie;

    [SerializeField] private PlayerSelectEnemy _selectedEnemy;

    [SerializeField] private EnemyStats _stats;
    [SerializeField] private PlayerDataSO _playerData;

    [SerializeField] private float _valueNeededForCriticAttack;

    private int _life;
    private int _damage;

    private void Start()
    {
        _life = _stats.healthPoints;
        _damage = _playerData.baseAttack;
    }

    private void OnEnable()
    {
        _selectedEnemy.OnEnemySelected += OnPlayerAttack_TakeDamage;
    }

    private void OnDisable()
    {
        _selectedEnemy.OnEnemySelected -= OnPlayerAttack_TakeDamage;
    }

    public void OnPlayerAttack_TakeDamage()
    {
        float criticValue = UnityEngine.Random.value;
        criticValue += (_playerData.baseLuck / 10);
        if (criticValue >= _valueNeededForCriticAttack)
        {
            _damage *= 2;
            _life -= _damage;
            _damage /= 2;
        }
        else
        {
            _life -= _damage;
        }

        OnEnemyTakeDamage?.Invoke(_life);

        if (_life <= 0)
        {
            _life = 0;
            OnEnemyDie?.Invoke();
        }
    }
}