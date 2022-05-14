using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DPickupBehavior : MonoBehaviour
{
    [SerializeField]
    private Player2DPickUpSO pickUpSO;
    public Player2DPickUpSO PickUpSO {get{return pickUpSO;}}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }

}
