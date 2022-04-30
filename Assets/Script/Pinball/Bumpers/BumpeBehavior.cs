using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpeBehavior : MonoBehaviour
{
    public float bumperForce = 0f;

    private void OnCollisionEnter(Collision other) {
        if(other.transform.CompareTag(("Player")))
        {
            other.rigidbody.AddExplosionForce(bumperForce, other.contacts[0].point,10);

        }
    }

}
