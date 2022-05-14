using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TMP_Text objectiveTracker;
    public Slider hpBar;

    public PlayerBehavior2D player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitializeManager());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateObjectivesTracker(int p_count)
    {
        objectiveTracker.text = p_count.ToString();
    }

    public void UpdateHealth()
    {
        hpBar.value = player.CurrentHealth;
    }

    private IEnumerator InitializeManager()
    {
        yield return new WaitForSeconds(0.5f);

        hpBar.maxValue = player.CurrentHealth;
        hpBar.value = hpBar.maxValue;
    }
    


}
