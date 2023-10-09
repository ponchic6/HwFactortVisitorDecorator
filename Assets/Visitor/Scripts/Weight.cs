using UnityEngine;

public class Weight
{
    private EnemyWieghtIncreaserVisitor _enemyWieghtIncreaserVisitor;
    private EnemyWeightReducerVisitor _enemyWeightReducerVisitor;
    private IEnemySpawnNotifier _enemySpawnNotifier;
    private IEnemyDeathNotifier _enemyDeathNotifier;
    public Weight(IEnemySpawnNotifier enemySpawnNotifier, IEnemyDeathNotifier enemyDeathNotifier)
    {

        _enemySpawnNotifier = enemySpawnNotifier;
        _enemySpawnNotifier.NotifiedAboutSpawn += OnEnemySpawn;

        _enemyDeathNotifier = enemyDeathNotifier;
        _enemyDeathNotifier.NotifiedAboutDeath += OnEnemyDeath;
        
        _enemyWieghtIncreaserVisitor = new EnemyWieghtIncreaserVisitor();
        _enemyWeightReducerVisitor = new EnemyWeightReducerVisitor();
        
    }

    ~Weight()
    {
        _enemySpawnNotifier.NotifiedAboutSpawn -= OnEnemySpawn;
        _enemyDeathNotifier.NotifiedAboutDeath -= OnEnemyDeath;
    }

    public int Value => _enemyWieghtIncreaserVisitor.Value + _enemyWeightReducerVisitor.Value;

    private void OnEnemyDeath(Enemy enemy)
    {
        enemy.Accept(_enemyWeightReducerVisitor);
        Debug.Log($"Вес {Value}");
    }

    private void OnEnemySpawn(Enemy enemy)
    {
        enemy.Accept(_enemyWieghtIncreaserVisitor);
        Debug.Log($"Вес {Value}");
    }
}