using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

[CreateAssetMenu(fileName = "IconFactory", menuName = "Factory/IconFactory")]
public class IconFactory : ScriptableObject
{
    [SerializeField] private IconConfig _iconConfig;
    
    public Image Get(MoneyIconsType moneyIcon)
    {
        Image instance = Instantiate(GetMoneyIcon(moneyIcon));
        return instance;
    }

    public Image Get(EnegryIconsType enegryIcon)
    {
        Image instance = Instantiate(GetEnergyIcon(enegryIcon));
        return instance;
    }

    private Image GetEnergyIcon(EnegryIconsType energyIcon)
    {
        switch (energyIcon)
        {
            case EnegryIconsType.BlackEnergy:
                return _iconConfig.BlackEnergy;
            
            case EnegryIconsType.OrangeEnergy:
                return _iconConfig.OrangeEnergy;
            
            default:
                throw new ArgumentException(nameof(energyIcon));
        }
    }

    private Image GetMoneyIcon(MoneyIconsType moneyIcon)
    {
        switch (moneyIcon)
        {
            case MoneyIconsType.LuckyMoney:
                return _iconConfig.LuckyMoney;
            
            case MoneyIconsType.SmileMoney:
                return _iconConfig.SmileMoney;
            
            default:
                throw new ArgumentException(nameof(moneyIcon));
        }
    }
}