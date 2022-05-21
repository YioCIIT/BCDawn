using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;
    public int level;
    public float[] location;

    //Constructor
    public PlayerData (SavingExamplePlayer player)
    {
        health = player.health_c;
        level = player.level_c;

        location = new float[3];
        location[0] = player.location_c.x;
        location[1] = player.location_c.y;
        location[2] = player.location_c.z;

    }


}
