using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    [SerializeField] private EnemyHealthSystem _healthSystem;

    private void OnEnable()
    {
        _healthSystem.OnEnemyDie += OnEnemyDie_SetGameObjectToFalse;
    }

    private void OnDisable()
    {
        _healthSystem.OnEnemyDie -= OnEnemyDie_SetGameObjectToFalse;
    }

    public void OnEnemyDie_SetGameObjectToFalse()
    {
        gameObject.SetActive(false);
    }
}
