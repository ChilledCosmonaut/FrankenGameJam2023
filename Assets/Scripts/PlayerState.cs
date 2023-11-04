using UnityEngine;
using UnityEngine.Events;

public class PlayerState : MonoBehaviour
{
    [SerializeField]
    private int money = 0;
    public UnityAction<int> OnMoneyChange;
    public int ChangeMoney
    {
        set { 
            money += value;
            OnMoneyChange(money);
        }
    }

    [SerializeField]
    private int reputation = 0;
    public UnityAction<int> OnReputationChange;
    public int ChangeReputation
    {
        set { 
            reputation += value;
            OnReputationChange(reputation);
        }
    }

    [SerializeField]
    private float speed;
    public UnityAction<int> OnSpeedChange;
    public float ModifySpeed
    {
        set { 
            speed *= value;
            OnSpeedChange(reputation);
        }
    }
}
