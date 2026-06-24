using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    //TODO: Example of using 
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private int _prewarmCount = 5;

    private ObjectPool<Enemy> _pool;
    private EntityMediator _mediator;

    private void Awake()
    {
        _mediator = new EntityMediator();
        _pool = new ObjectPool<Enemy>(_enemyPrefab, transform);
        _pool.Prewarm(_prewarmCount);

        _mediator.OnEntityDisabled += e => _pool.Release((Enemy)e);
    }

    public void SpawnAt(Vector3 position)
    {
        var enemy = _pool.Get();
        enemy.Initialize(position);
        _mediator.Register(enemy);
    }

    public int ActiveCount => _mediator.ActiveCount;
}
