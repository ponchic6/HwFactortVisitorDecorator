using System;
using UnityEngine;

public class VisitorBootstrap : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;

    private Score _score;

    private void Awake()
    {
        _score = new Score(_spawner);
        _spawner.StartWork();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spawner.KillRandomEnemy();
        }
    }
}