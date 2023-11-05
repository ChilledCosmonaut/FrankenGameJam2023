using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricP1 : MonoBehaviour
{


    public int moneyPerSecond;
    public int reputationPerSecond;
    public int cost;

    
    [SerializeField]
    public PlayerState p1Stats;
    // Start is called before the first frame update
    void OnEnable()
    {
        InvokeRepeating("IncreaseValue", 1.0f, 1.0f);
        p1Stats.ChangeMoney = -cost;
    }


    private void IncreaseValue()
    {
        p1Stats.ChangeMoney =moneyPerSecond;
        p1Stats.ChangeReputation = reputationPerSecond; 
    }

    void OnDisable()
    {
        CancelInvoke("IncreaseValue");
    }
    
}
