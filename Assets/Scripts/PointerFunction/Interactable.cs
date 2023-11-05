using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
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

    

    bool player1da = false;
    bool player2da = false;

    public bool player1IsInteracting = false;
    public bool player2IsInteracting = false;

    public float distP1, distP2;

    public float triggerDist;
    

    // Start is called before the first frame update
    void Start()
    {
       player1 = GameObject.Find("Player1");
       player2 = GameObject.Find("Player2");

       p1Interface= player1.GetComponent<PlayerState>().PlayerUI;
       p2Interface= player2.GetComponent<PlayerState>().PlayerUI;
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
        player1IsInteracting = true;

        PlayerState p1S = GameObject.Find("Player1").GetComponent<PlayerState>();
        

        p1Interface.SetActive(true);

        if(Input.GetKey(KeyCode.A))
        {
            fabricBlu.GetComponent<FabricP1>().p1Stats = p1S;
            fabricBlu.SetActive(true);
            p1Interface.SetActive(false);
            BruchLand.SetActive(false);
            player1IsInteracting = false;
            Destroy(this);
            
        }

        if(Input.GetKey(KeyCode.D))
        {
            parkBlu.GetComponent<FabricP1>().p1Stats = p1S;
            parkBlu.SetActive(true);
            p1Interface.SetActive(false);
            BruchLand.SetActive(false);
            player1IsInteracting = false;
            Destroy(this);
        }

    }

    public void Player2Interaction()
    {
        PlayerState p2S = GameObject.Find("Player2").GetComponent<PlayerState>();

        player2IsInteracting = true;

        p2Interface.SetActive(true);

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            fabricRed.GetComponent<FabricP1>().p1Stats = p2S;
            fabricRed.SetActive(true);
            p2Interface.SetActive(false);
            BruchLand.SetActive(false);
            player2IsInteracting = false;
            Destroy(this);
            
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            parkRed.GetComponent<FabricP1>().p1Stats = p2S;
            parkRed.SetActive(true);
            p2Interface.SetActive(false);
            BruchLand.SetActive(false);
            player2IsInteracting = false;
            Destroy(this);
        }
    }
}
