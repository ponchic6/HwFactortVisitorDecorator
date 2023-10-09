using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour, IEnemyDeathNotifier, IEnemySpawnNotifier
{
    public event Action<Enemy> NotifiedAboutDeath;
    public event Action<Enemy> NotifiedAboutSpawn;

    [SerializeField] private float _spawnCooldown;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private EnemyFactory _enemyFactory;
    [SerializeField] private int _maxWeight;
    private int _currentWeight = 0;

    private List<Enemy> _spawnedEnemies = new List<Enemy>();
    private Coroutine _spawn;
    private Weight _weight;
    private void Awake()
    {
        _weight = new Weight(this, this);
    }

    public void StartWork()
    {
        StopWork();

        _spawn = StartCoroutine(Spawn());
    }

    public void StopWork()
    {
        if (_spawn != null)
            StopCoroutine(_spawn);
    }

    public void KillRandomEnemy()
    {
        if (_spawnedEnemies.Count == 0) 
            return;

        _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            if (_weight.Value < _maxWeight)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                NotifiedAboutSpawn?.Invoke(enemy);
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                _spawnedEnemies.Add(enemy);
                enemy.Died += OnEnemyDied;
            }
            yield return new WaitForSeconds(_spawnCooldown);
        }
    }

    private void OnEnemyDied(Enemy enemy)
    {
        NotifiedAboutDeath?.Invoke(enemy);
        enemy.Died -= OnEnemyDied;
        _spawnedEnemies.Remove(enemy);
    }
}