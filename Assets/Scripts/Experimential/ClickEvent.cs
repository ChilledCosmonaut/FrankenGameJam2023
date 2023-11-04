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

   Camera m_MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        m_MainCamera = Camera.main;

        transform.LookAt(m_MainCamera.transform);
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
            print("event start");
            Destroy(gameObject);
        }
    }
}
