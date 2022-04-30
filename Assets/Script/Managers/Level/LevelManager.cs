using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public AudioManager audMngr;

    //list
    private List<ObjectiveBehavior> objList = new List<ObjectiveBehavior>();

    // Start is called before the first frame update
    void Start()
    {
        audMngr.Play("BGM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddObjective(ObjectiveBehavior p_objective)
    {
        objList.Add(p_objective);
    }

    public void CheckObtainedObjectives()
    {   
        FindObjectOfType<UIManager>().UpdateObjectivesTracker(objList.Count);
        FindObjectOfType<AudioManager>().Play("Button");
    }
}
