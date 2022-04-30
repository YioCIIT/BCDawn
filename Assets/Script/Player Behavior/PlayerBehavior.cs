using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float maxHp;
    public float currentHp;
   
    private UIManager uiManager;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        uiManager = FindObjectOfType<UIManager>();
        uiManager.hpBar.maxValue = maxHp;
        uiManager.hpBar.value = currentHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDamaged(float p_dmg)
    {
        currentHp -= p_dmg;
        uiManager.hpBar.value = currentHp;

        if(currentHp < maxHp * 0.20f)
        {
            FindObjectOfType<AudioManager>().Play("Low Health");
        }
    }
}
