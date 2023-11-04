using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEvent : MonoBehaviour
{
    public GameObject prob;

    public Transform spot;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prob, spot.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
