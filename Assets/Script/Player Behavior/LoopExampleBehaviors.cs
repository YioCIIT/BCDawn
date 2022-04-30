using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoopExampleBehaviors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool CheckIfFive(int input)
    {

        if(input == 5)
        {
            return true;
        }

        return false;
        
    }


    private IEnumerator CoroutineFunc()
    {

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(" FOR LOOP Coroutine: i is: " +i);

            yield return new WaitForSeconds(1f);
        }

        Debug.Log (" _________ FUNCTION END ___________");

    }

    public void DoWhileLoop()
    {
        int i = 0;
        int j = 5;
        
        while (i<5)
        {
            Debug.Log(" WHILE LOOP: i is: " + i);
            i++;
        }

        do
        {
            Debug.Log(" DO WHILE LOOP: j is: " + j);
            j--;
        }while(j>0);

        
        Debug.Log(" is i 5?: " + CheckIfFive(i));
        Debug.Log(" is j 5?: " + CheckIfFive(j));

        Debug.Log (" _________ FUNCTION END ___________");
    }

    public void ForLoop()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(" FOR LOOP: i is: " +i);
        }

        Debug.Log (" _________ FUNCTION END ___________");
    }

    public void CoroutineButton()
    {
        StartCoroutine(CoroutineFunc());
    }



    
}
