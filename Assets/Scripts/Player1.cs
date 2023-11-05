using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player1 : MonoBehaviour
{

    public GameObject cursor;
    public GameObject wayPoint;
    public float speed = 5f;

    private bool isMoving;
    private Vector3 orgiPos, targetPos;
    private float timeToMove = 0.2f;

    public float distance;

   

    NavMeshAgent _navAgent;
    void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.forward));
        }
        
        if(Input.GetKey(KeyCode.A)&& !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }

        if(Input.GetKey(KeyCode.S)&& !isMoving)
        {
            StartCoroutine(MovePlayer(-Vector3.forward));
        }

        if(Input.GetKey(KeyCode.D)&& !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }

        distance = Vector3.Distance(transform.position, wayPoint.transform.position);

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            wayPoint.transform.position = cursor.transform.position;
            StartCoroutine(GoTo());
            print("kek");
        }

        /////////////////////////////////////////////////////////////////////////
        //Falls es mit den zwei Mäusen funktioniert hier drunter ist der originale movement Code, 
        //einfach in ein neues Script kopieren und auf den spieler ziehen
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

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        orgiPos = cursor.transform.position;
        targetPos = orgiPos + direction*7;

        while(elapsedTime < timeToMove)
        {
            cursor.transform.position = Vector3.Lerp(orgiPos, targetPos, (elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        cursor.transform.position = targetPos;

        isMoving = false;
    }

    private IEnumerator GoTo()
    {
        while(distance > 0.6)
        {
             _navAgent.SetDestination(wayPoint.transform.position);
             yield return null;
        }
    }
}
