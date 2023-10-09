using System;
using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player.Initialize(new PassiveAbilityPlayer(new PlayerSpecialization(
            new PlayerSpecies(new BasePlayerStats(), Species.Human), Specializations.Wizard), PassiveAbility.HotBlood));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _player.GetStats();
    }
}