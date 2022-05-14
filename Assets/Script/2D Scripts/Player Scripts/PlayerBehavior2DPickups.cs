using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior2DPickups : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Pick Up")
        {
            Player2DPickupBehavior pickUp = other.transform.GetComponent<Player2DPickupBehavior>();
            
            switch(pickUp.PickUpSO.kind)
            {
                case pickUpKind.hp:
                    
                    this.GetComponent<PlayerBehavior2D>().UpdateHealth(false, pickUp.PickUpSO.pickupValue);
                    uiManager.UpdateHealth();
                    break;

                case pickUpKind.speed:
                    
                    break;
                case pickUpKind.none:
                    Debug.LogWarning("PICK UP SET TO NONE");
                    break;
            }
        }
    }

    public void TestFunc(float val)
    {
        this.GetComponent<PlayerBehavior2D>().UpdateHealth(true, val);
        uiManager.UpdateHealth();
    }

}
