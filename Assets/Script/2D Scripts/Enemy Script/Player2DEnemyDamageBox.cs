using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DEnemyDamageBox : MonoBehaviour
{
    float damageOutput;

    // Start is called before the first frame update
    void Start()
    {
        damageOutput = transform.parent.GetComponent<Player2DEnemyBehavior>().DamageOuput;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            other.transform.GetComponent<PlayerBehavior2D>().UpdateHealth(true, damageOutput);
        }
    }
}
