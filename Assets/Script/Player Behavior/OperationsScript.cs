using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OperationsScript : MonoBehaviour
{
    //Data types
    // int 4 bytes   -2,147,483,648 to 2,147,483,647
    // long 8 bytes -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

    // float 4 bytes 6 to 7 decimal digits
    // double 8 bytes 15 decimal digits
    
    // bool 1 bit true or false
    // char 2 bytes Stores a single character/letter 
    // string 2 byte / character - an array of characters 

    private int digits = 15;
    private long digitsPeroLong;

    private char letter = 'A';
    private int letterToInt;

    private bool operationBool;

    public int barya;
    
    public GameObject InputFieldUI1 = null;

    public InputField InputFieldUI2;

    public Text operationText;
    public Text answerText;

    public Text demoText;

    //Casting
    // Implicit Casting
    // char -> int -> long -> float -> double
    //digitsPeroLong = digits;

    // Explicit Casting
    //double -> float -> long -> int -> char
    //digits = (int)digitsPeroLong;
    //digits = digitsPeroLong <- WILL NOT WORK

    // Start is called before the first frame update
    void Start()
    {

        #region  Operations
        // Debug.Log("Digits: " + digits);

        // digits = digits + digits;

        // digits += digits;

        // Debug.Log("Digits after being added to itself: " + digits);

        // digits = digits / 2;

        // Debug.Log("Digits: " + digits);

        // digits = digits * 3;
        
        // Debug.Log("Digits: " + digits);

        // digits = digits % 2;

        // Debug.Log("Digits: " + digits);

        // digits++;

        // ++digits;

        // Debug.Log("Digits: " + digits);

        // digits--;
        
        // Debug.Log("Digits: " + digits);
        #endregion
        
        #region Casting
        //Implicit
        digitsPeroLong = digits;

        //Debug.Log("Before Casting: " + letter + " " + letterToInt);

        letterToInt = letter;

        //Debug.Log("After Casting: " + letter + " " + letterToInt);

        //Explicit

        digits = (int)digitsPeroLong;

        #endregion
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OperationToUse(bool op)
    {
        if(op == true)
        {
            operationBool = op;
            operationText.text = "+";

            demoText.text = "Mark";
        }

        else
        {
            operationBool = op;
            operationText.text = "-";

            demoText.text = "Ruffolo";
        }
    }


    public void ManongSukli()
    {
        string sA = InputFieldUI1.GetComponent<InputField>().text;
        string sB = InputFieldUI2.text;

        //checks for Char
        if(sA.Any(x => char.IsLetter(x)) || sB.Any(x => char.IsLetter(x)))
        {
            Debug.Log("Parecakes may letter. Paayos pls");
            return;
        }


        int a = ChecksNullInput(sA);
        int b = ChecksNullInput(sB);
        
        if(operationBool)
        {
            barya = a + b;            
        }

        else 
        {
            barya = a - b;
        }
               
        
        if(barya > 10)
        {
            Debug.Log("Ang galing mas marami sa sampu. " + barya);
        }

        else if(barya < 10)
        {
            Debug.Log("Ay wow kulang sa sampu " + barya);
        }

        else 
        {
            Debug.Log("Sad lods sampu lang " + barya);
        }

        answerText.text = "= " + barya;
    }

    private int ChecksNullInput(string input)
    {   
        int ran = 0;

        //-2,147,483,648 to 2,147,483,647
        if(input == "")
        {
            ran = Random.Range(-2147483648, 2147483647);
        }
        else
        {
            ran = int.Parse(input);
        }

        return ran;
    }

}
