using UnityEngine;
using UnityEngine.UI;

public class UiEnemyRecieveDamage : MonoBehaviour
{
    [SerializeField] private EnemyHealthSystem _healthSystem;
    [SerializeField] private EnemyStats _stats;

    [SerializeField] private Image _lifeBar;

    private void OnEnable()
    {
        _healthSystem.OnEnemyTakeDamage += OnEnemyRecieveDamage_LerpLifeBar;
    }

    private void OnDisable()
    {
        _healthSystem.OnEnemyTakeDamage -= OnEnemyRecieveDamage_LerpLifeBar;
    }

    public void OnEnemyRecieveDamage_LerpLifeBar(int life)
    {
        _lifeBar.fillAmount = life / (float)_stats.healthPoints;
    }
}
