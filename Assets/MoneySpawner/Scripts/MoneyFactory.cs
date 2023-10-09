using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoneyFactory", menuName = "Factory/MoneyFactory")]
public class MoneyFactory : ScriptableObject
{
    [SerializeField] private GameObject _moneyPrefab;
    
    public GameObject Get()
    {
        GameObject instance = Instantiate(_moneyPrefab, SetMoneyPos(), Quaternion.Euler(90, 0, 0));
        return instance;
    }

    private Vector3 SetMoneyPos()
    {
        return new Vector3(Random.value * 20, 1, Random.value * 20);
    }
}
