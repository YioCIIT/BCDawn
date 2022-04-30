using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TMP_Text objectiveTracker;
    public Slider hpBar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateObjectivesTracker(int p_count)
    {
        objectiveTracker.text = p_count.ToString();
    }
}
