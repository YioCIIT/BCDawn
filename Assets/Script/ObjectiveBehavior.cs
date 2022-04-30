using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveBehavior : MonoBehaviour
{
    public char objectiveLetter = 'a';

    public Material mat1 = null;
    public Material mat2 = null;

    public Transform playerT = null;

    private bool hasInteracted = false;

    private Vector3 heading = new Vector3(0,0,0);
    public float playerRange = 0f;

    private float distance;

    public void Obtain()
    {
        Destroy(gameObject);
    }


    private void Update() {
        heading = this.transform.position - playerT.position;
        var distance = heading.magnitude;
        var direction = heading / distance;

        if(distance < playerRange){
            this.GetComponent<Renderer>().material = mat2;
            
            if(!hasInteracted)
            {
                FindObjectOfType<AudioManager>().Play("Interact");
                hasInteracted = true;
            }

            return;
        }
      
        hasInteracted = false;
        this.GetComponent<Renderer>().material = mat1;
    }
}
