using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyFactory _enemyFactory;
    private IEnemy _enemy = IEnemy.CreateDefault();
    private void Start()
    {
        if (_enemyFactory != null)
        {
            _enemy = _enemyFactory.CreateEnemy();
        }
        
        _enemy.Move();
    }
}
