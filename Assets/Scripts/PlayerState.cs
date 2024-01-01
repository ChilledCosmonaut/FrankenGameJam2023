using UnityEngine;
using UnityEngine.Events;

public class PlayerState : MonoBehaviour
{
    public GameObject PlayerUI;

    [SerializeField]
    public int money = 0;
    public UnityEvent<int> OnMoneyChange;
    public int ChangeMoney
    {
        set { 
            money += value;
            OnMoneyChange.Invoke(money);
        }
    }

    [SerializeField]
    private int reputation = 0;
    public UnityEvent<int> OnReputationChange;
    public int ChangeReputation
    {
        set { 
            reputation += value;
            OnReputationChange.Invoke(reputation);
        }
    }

    [SerializeField]
    private float speed;
    public UnityEvent<int> OnSpeedChange;
    public float ModifySpeed
    {
        set { 
            speed *= value;
            OnSpeedChange.Invoke(reputation);
        }
    }
}
