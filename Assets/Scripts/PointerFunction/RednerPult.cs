using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RednerPult : MonoBehaviour
{
   public GameObject player1;
    public GameObject player2;

    public GameObject BruchLand;

    public GameObject fabricBlu;
    public GameObject parkBlu;

    public GameObject fabricRed;
    public GameObject parkRed;

    public GameObject p1Interface;
    public GameObject p2Interface;

    public PlayerState playerState1, playerState2;

    bool player1da = false;
    bool player2da = false;

    public bool player1IsInteracting = false;
    public bool player2IsInteracting = false;

    public float distP1, distP2;

    public float triggerDist;

    public float player1Timer, player2Timer;

    public int publicityPlus;
    

    // Start is called before the first frame update
    void Start()
    {
       player1 = GameObject.Find("Player1");
       player2 = GameObject.Find("Player2");

      
    }

    // Update is called once per frame
    void Update()
    {
        distP1 = Vector3.Distance(transform.position, player1.transform.position);
        distP2 = Vector3.Distance(transform.position, player2.transform.position);

        if(player1da && distP1 < triggerDist && !player2da)
        {
            //player 1 selected that plot
            Player1Interaction();
        }

        if(player2da && distP2 < triggerDist&&!player1da )
        {
            //player 1 selected that plot
            Player2Interaction();
        }


        
    }

    public void IneractionStart(float who)
    {
        if(who ==1)
        {
            player1da = true;
        }
        else
        {
            player2da = true;
        }
    }

    public void Player1Interaction()
    {
        player1Timer += Time.deltaTime;
        if(player1Timer >= 1)
        {
            playerState1.ChangeReputation = publicityPlus;
            player1Timer = 0;
        }


    }

    public void Player2Interaction()
    {
        player2Timer += Time.deltaTime;
        if(player2Timer >= 1)
        {
            playerState2.ChangeReputation = publicityPlus;
            player2Timer = 0;
        }
    }
}
