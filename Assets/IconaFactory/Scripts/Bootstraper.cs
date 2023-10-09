using System;
using UnityEngine;
using UnityEngine.UI;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private EnegryIconsType _enegryIcon;
    [SerializeField] private MoneyIconsType _moneyIcon;
    [SerializeField] private IconFactory _iconFactory;
    [SerializeField] private GameObject _panel;
    public void Awake()
    {    
        Image energyInstance;
        Image moneyInstance;
        switch (_enegryIcon)
        {
            case EnegryIconsType.BlackEnergy:
                energyInstance = _iconFactory.Get(EnegryIconsType.BlackEnergy);
                energyInstance.transform.SetParent(_panel.transform);
                energyInstance.transform.localPosition = new Vector3(150, 30, 0);
                break;
            
            case EnegryIconsType.OrangeEnergy:
                energyInstance = _iconFactory.Get(EnegryIconsType.OrangeEnergy);
                energyInstance.transform.SetParent(_panel.transform);
                energyInstance.transform.localPosition = new Vector3(150, 30, 0);
                break;
        }
        
        switch (_moneyIcon)
        {
            case MoneyIconsType.LuckyMoney:
                moneyInstance = _iconFactory.Get(MoneyIconsType.LuckyMoney);
                moneyInstance.transform.SetParent(_panel.transform);
                moneyInstance.transform.localPosition = new Vector3(-150, 30, 0);
                break;
            
            case MoneyIconsType.SmileMoney:
                moneyInstance = _iconFactory.Get(MoneyIconsType.SmileMoney);
                moneyInstance.transform.SetParent(_panel.transform);
                moneyInstance.transform.localPosition = new Vector3(-150, 30, 0);
                break;
        }

    }
}
