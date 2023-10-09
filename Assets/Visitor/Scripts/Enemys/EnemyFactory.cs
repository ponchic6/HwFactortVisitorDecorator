﻿using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Factory", menuName = "EnemyFactory")]
public class EnemyFactory : ScriptableObject
{
    [SerializeField] private Human _humanPrefab;
    [SerializeField] private Ork _orkPrefab;
    [SerializeField] private Elf _elfPrefab;

    public Enemy Get(EnemyType type)
    {
        switch (type)
        {
            case EnemyType.Elf:
                return Instantiate(_elfPrefab);
            
            case EnemyType.Human:
                return Instantiate(_humanPrefab);
            
            case EnemyType.Ork:
                return Instantiate(_orkPrefab);
            
            default:
                throw new ArgumentException();
        }
    }
}