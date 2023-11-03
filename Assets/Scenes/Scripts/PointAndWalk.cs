using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndWalk : MonoBehaviour
{
    NavMeshAgent _navAgent;
    // Start is called before the first frame update
    void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000, _navAgent.areaMask))
            {
                _navAgent.SetDestination(hit.point);
            }
        }
    }
}
