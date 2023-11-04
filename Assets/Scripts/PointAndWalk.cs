using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndWalk : MonoBehaviour
{

    public GameObject cursor;
    public float speed = 5f;

    NavMeshAgent _navAgent;
    void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        _navAgent.SetDestination(cursor.transform.position);

        if(Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.up);
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }

        if(Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.down);
        }

        if(Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }

        /*
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000, _navAgent.areaMask))
            {
                
            }
        }
        */
    }

    private void MovePlayer(Vector3 direction)
    {
        cursor.transform.Translate(direction * speed * Time.deltaTime);
    }
}
