using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{

    public float eventTriggerR = 3.5f;
    public float time;
    public float distance;

    public bool isActive = false;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnMouseDown()
   {
       isActive = true;
   }

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(transform.position, player.transform.position);
        if(isActive && distance < eventTriggerR)
        {
            Destroy(gameObject);
        }
    }
}
