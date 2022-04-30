using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherBehavior : MonoBehaviour
{
    private bool isInsideArea = true;

    private Rigidbody ball = null;

    public float launchForce = 0f;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player"))
        {
            isInsideArea = true;

            if(ball == null)
            {
                ball = other.gameObject.GetComponent<Rigidbody>();
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            isInsideArea = false;
        }
    }

    public void LaunchBall()
    {
        if(ball == null)
        {
            return;
        }

        if(isInsideArea)
        {
            ball.AddForce(new Vector3(0f,0f,launchForce), ForceMode.Impulse);
        }
    }
}
