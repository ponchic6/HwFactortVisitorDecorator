﻿using System;

public interface IEnemySpawnNotifier
{
    event Action<Enemy> NotifiedAboutSpawn;
}