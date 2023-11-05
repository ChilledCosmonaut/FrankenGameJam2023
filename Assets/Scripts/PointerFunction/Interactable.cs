using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    

    public GameObject player1;
    public GameObject player2;

    public GameObject fabric;
    public GameObject park;

    public GameObject p1Interface;
    public GameObject p2Interface;

    bool player1da = false;
    bool player2da = false;

    public bool player1IsInteracting = false;
    public bool player2IsInteracting = false;

    public float distP1, distP2;

    public float triggerDist;

    Player1 p1Script;


    // Start is called before the first frame update
    void Start()
    {
        GameObject p1 = GameObject.Find("Player1");
        p1Script = p1.GetComponent<Player1>();
    }

    // Update is called once per frame
    void Update()
    {
        distP1 = Vector3.Distance(transform.position, player1.transform.position);
        distP2 = Vector3.Distance(transform.position, player2.transform.position);

        if(player1da && distP1 < triggerDist )
        {
            //player 1 selected that plot
            Player1Interaction();
        }

        if(player2da && distP2 < triggerDist )
        {
            //player 1 selected that plot
            print("player 1 is doing something");
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
        p1Script.isInteracting1 = true;

        p1Interface.SetActive(true);

        if(Input.GetKey(KeyCode.A))
        {
            fabric.SetActive(true);
            p1Interface.SetActive(false);
            p1Script.isInteracting1 = false;
            Destroy(this);
            
        }

        if(Input.GetKey(KeyCode.D))
        {
            park.SetActive(true);
            p1Interface.SetActive(false);
            p1Script.isInteracting1 = false;
            Destroy(this);
        }

    }

    public void Player2Interaction()
    {
        
    }
}
