using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEvent : MonoBehaviour
{
    public GameObject prob;

    Vector3 kek;
    // Start is called before the first frame update
    void Start()
    {
        kek = new Vector3(0,2,0);
        Instantiate(prob, transform.position + kek, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
