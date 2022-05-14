using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum pickUpKind
{
    none = 0,
    hp = 1,
    speed = 2,
    coin = 3
}

[CreateAssetMenu(fileName = "Player2DPickUpSO", menuName = "BCDawn/Player2DPickUpSO", order = 0)]
public class Player2DPickUpSO : ScriptableObject {
    
    public string pickupName; 

    public pickUpKind kind;

    public float pickupValue;
}
