using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{

    public Transform playerT = null;
    public Transform targetT = null;

    public float yOffset = 0f;

    //public float playerRange = 0f;

    public bool multiplyByMagnitude = false;

    private Vector3 heading = new Vector3(0,0,0);

    private Vector2 vect1 = new Vector2(3,5);
    private Vector2 vect2 = new Vector2(2,-1);
    private Vector2 solVect = new Vector2(0,0);

    public Transform xvect1 = null;
    public Transform xvect2 = null;
    public Transform xvect3 = null;

    public bool showLerp = false;

    //Lerp
    [Range(0,1)]
    public float lerpPos = 0f;
    
    public float speed;

    private float startTime;

    private float journeyLength;

    //Rotation
    public float rotationSpeed;
    float x;
    float y;
    float z;

    private Vector3 normal = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        //solVect = vect1 + vect2;
        solVect = vect1 - vect2;
        //Debug.Log(Vector3.Lerp(xvect1.position, xvect2.position, 0.5f));
        //Debug.Log(solVect);

        startTime = Time.time;

        if(showLerp)
        {
            journeyLength = Vector3.Distance(xvect1.position, xvect2.position);
        }

    }

    // Update is called once per frame
    void Update()
    {
         // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        if(showLerp)
        {
            xvect3.position =  Vector3.Lerp(xvect1.position, xvect2.position, fractionOfJourney);

            xvect3.eulerAngles += new Vector3(x -= 1, y += 2, z += 1) * Time.deltaTime * rotationSpeed;

            if(Vector3.Equals(xvect3,xvect2))
            {
                xvect3.position =  Vector3.Lerp(xvect2.position, xvect1.position,fractionOfJourney);
            }else
            {
                xvect3.position =  Vector3.Lerp(xvect1.position, xvect2.position, fractionOfJourney);
            }
        }




        // heading = targetT.position - playerT.position;
        // var distance = heading.magnitude;
        // var direction = heading / distance;
        // // Debug.Log("Player to target heading: " + heading + "\n Player to target distance: " + distance + 
        // // "\n Player to target normalized direction: " + direction + 
        // // "\n Player to target multiplied magnitude: " + (direction * distance).magnitude);
    
        // if(distance > playerRange)
        // {
        //     targetT.GetComponent<ObjectiveBehavior>().IsInRange(false); //<- need to update Objective Behavior
        // }else{
        //     targetT.GetComponent<ObjectiveBehavior>().IsInRange(true); //<-  need to update Objective Behavior
        // }

        // Vector3 side1 = xvect2.position - xvect1.position;
        // Vector3 side2 = xvect3.position - xvect1.position;

        // normal =  Vector3.Cross(side1,side2);

        // Debug.Log(normal);

    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.cyan;
        var distance = heading.magnitude;
        var direction = heading / distance;
        
        if(multiplyByMagnitude)
        {
            Gizmos.DrawRay(transform.position + new Vector3(0f,yOffset,0f), normal * normal.magnitude);
        }else{
            Gizmos.DrawRay(transform.position + new Vector3(0f,yOffset,0f), direction);
        }
    }
}
