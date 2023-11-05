using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    bool player1da = false;
    bool player2da = false;

    public float distP1, distP2;

    public float triggerDist;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distP1 = Vector3.Distance(transform.position, player1.transform.position);
        distP2 = Vector3.Distance(transform.position, player2.transform.position);

        if(player1da && distP1 < triggerDist )
        {
            //player 1 selected that plot
            print("player 1 is doing something");
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
}
