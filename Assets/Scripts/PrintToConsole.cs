using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float a = 55;
        float b = 100;
        float c = a + b; // here we can use other math operators /,-,* etc.

        string name = "ahmet";
        string surname = "test";
        
        Debug.Log("a + b = " + c); //concatenate the string with integer and print to console...
        Debug.Log(a +" + " +  b  + " = " + c); //concatenate the string with integer and print to console...
        
        print(name + " " + surname); // we can also use print to console
        
        // lets use method here
        CalculateTwoNumbers(a,b);
        
        //let do this with return float
        float result = ReturnTwoNumbers(a, b);
        print(result);
        
    }
    
    //lets create a function that calculate upon we did
    void CalculateTwoNumbers(float a, float b)
    {
        float res = a + b;
        Debug.Log(a + " + " + b + " = " + res);
    }
    
    // Moreover, we can return directly float instead of void function
    float ReturnTwoNumbers(float a, float b)
    {
        return a + b;
    }
}
