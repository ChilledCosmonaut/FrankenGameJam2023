using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerSelect : MonoBehaviour
{
    public float raycastDistance = 10f;

    private void Update()
    {
        // Create a raycast from the current position, straight down
        Ray ray = new Ray(transform.position, Vector3.down);

        // Create a RaycastHit object to store the hit information
        RaycastHit hit;

        // Perform the raycast
        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            

            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                // Check if the hit object has a tag
                if (hit.collider.CompareTag("Interactable")) // Replace "YourTag" with the tag you want to look for
                {
                    // The hit object has the desired tag
                    Debug.Log("Hit object with the tag 'YourTag'.");
                }

                Debug.Log(hit.point);
            }
        }

        
    }
}
