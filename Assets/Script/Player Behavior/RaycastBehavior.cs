using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastBehavior : MonoBehaviour
{
    public float rayLength = 10f;

    public LevelManager lvlMngr;

    Vector3 yOffset = new Vector3(0, 1f, 0);


    private void Update() {
        
        RaycastHit hit;

        if(Physics.Raycast(transform.position + yOffset, transform.TransformDirection(0f,0f,1), out hit, rayLength))
        {
            if(hit.transform.GetComponent<ObjectiveBehavior>())
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    lvlMngr.AddObjective(hit.transform.GetComponent<ObjectiveBehavior>());
                    FindObjectOfType<AudioManager>().Play("Obtain");

                    hit.transform.GetComponent<ObjectiveBehavior>().Obtain();
                }
            }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(0,0f,1) * rayLength;
        Gizmos.DrawRay(transform.position + yOffset, direction);
    }
}
