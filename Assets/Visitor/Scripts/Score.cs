using UnityEngine;

public class Score
{
    private EnemyScoreVisitor _enemyScoreVisitor;
    private IEnemyDeathNotifier _enemyDeathNotifier;

    public Score(IEnemyDeathNotifier enemyDeathNotifier)
    {
        _enemyDeathNotifier = enemyDeathNotifier;
        _enemyDeathNotifier.NotifiedAboutDeath += OnEnemyKilled;

        _enemyScoreVisitor = new EnemyScoreVisitor();
    }

    ~Score() => _enemyDeathNotifier.NotifiedAboutDeath -= OnEnemyKilled;

    public int Value => _enemyScoreVisitor.Value;
    private void OnEnemyKilled(Enemy enemy)
    {
        enemy.Accept(_enemyScoreVisitor);
        Debug.Log($"Очки {Value}");
    }
}