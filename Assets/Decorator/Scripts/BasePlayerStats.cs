using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerStats : IPlayerStats
{
    public BasePlayerStats()
    {
        Strenght = 10;
        Agility = 10;
        Intelligence = 10;
    }
    public int Strenght {get; set; }
    public int Agility {get; set; }
    public int Intelligence {get; set; }
    
}