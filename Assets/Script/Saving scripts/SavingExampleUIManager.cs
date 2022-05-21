using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SavingExampleUIManager : MonoBehaviour
{
    public SavingExamplePlayer player;

    public TextMeshProUGUI[] currentT = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] savedT = new TextMeshProUGUI[3];
    public TextMeshProUGUI[] loadedT = new TextMeshProUGUI[3];

    private bool isMoving;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   private void LateUpdate() {
        
        if(isMoving)
        {
            player.location_c += new Vector3(1f,-2f,50f);
            currentT[2].text = player.location_c.ToString();
        }
    }

#region Button Functions

    public void HealthChange(bool p_isAdd)
    {
        player.health_c = p_isAdd ? player.health_c + 1 : player.health_c - 1;
        currentT[0].text = player.health_c.ToString(); 
    }
    public void LevelChange(bool p_isAdd)
    {
        player.level_c = p_isAdd ? player.level_c + 1 : player.level_c - 1; 
        currentT[1].text = player.level_c.ToString();
    }

    public void SaveButton()
    {
        player.SavePlayer();

        savedT[0].text = player.health_c.ToString();
        savedT[1].text = player.level_c.ToString();
        savedT[2].text = player.location_c.ToString();
    }

    public void LoadButton()
    {
        player.LoadPlayer();

        loadedT[0].text = player.health_c.ToString();
        loadedT[1].text = player.level_c.ToString();
        loadedT[2].text = player.location_c.ToString();
    }

    public void ToggleMovement()
    {
        isMoving = !isMoving ? true : false;
    }
#endregion


}
