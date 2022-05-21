using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingExamplePlayer : MonoBehaviour
{
    public int health_c = 0;
    public int level_c = 0;
    public Vector3 location_c = new Vector3(0,0,0);


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        if(data == null)
        {
            return;
        }

        health_c = data.health;
        level_c = data.level;

        Vector3 saveFileLocation = new Vector3(data.location[0],data.location[1],data.location[2]);

        location_c = saveFileLocation;
    }

}
