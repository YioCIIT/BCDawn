using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DEnemyBehavior : MonoBehaviour
{
    [SerializeField]
    private float damageOutput = 0f;
    public float DamageOuput {get{return damageOutput;}}

    [Header("Locomotion")]
    [SerializeField]
    private float moveSpeed = 0f;

    private Rigidbody2D rb = null;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(-1f * moveSpeed, rb.velocity.y);
    }

}
