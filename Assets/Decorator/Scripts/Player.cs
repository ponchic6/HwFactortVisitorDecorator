using UnityEngine;

public class Player : MonoBehaviour
{
    private IPlayerStats _playerStats;

    public void Initialize(IPlayerStats playerStats)
    {
        _playerStats = playerStats;
    }

    public void GetStats()
    {
        Debug.Log($"Сила {_playerStats.Strenght}, Ловкость {_playerStats.Agility}, Интеллект {_playerStats.Intelligence}");
    }

}