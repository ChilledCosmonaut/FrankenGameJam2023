using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUpdate : MonoBehaviour
{
    public PlayerState playerState;

    public Text money;

    
        

    void GetUpdateDisplay(int money)
    {

    }

    void Update()
    {
        money.text =playerState.money.ToString();
    }


}
