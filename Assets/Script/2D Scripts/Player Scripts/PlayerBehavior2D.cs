using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior2D : MonoBehaviour
{
    [Header("Player Stats")]

    [SerializeField]
    private float maxHealth = 0f;
    private float currentHealth = 0f;
    public float CurrentHealth { get{ return currentHealth;}}

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


#region Health
    public void UpdateHealth(bool p_isDamage, float p_amount)
    {
        if(p_isDamage)
        {
            //ternary operation
            currentHealth = (currentHealth - p_amount <= 0) ? 0 : currentHealth - p_amount;
        }
        else
        {
            currentHealth = (currentHealth + p_amount >= maxHealth) ? maxHealth : currentHealth + p_amount;
        }
    }

#endregion
}
