using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 55;
        int b = 100;
        int c = a + b; // here we can use other math operators /,-,* etc.

        string name = "ahmet";
        string surname = "test";
        
        Debug.Log("a + b = " + c); //concatenate the string with integer and print to console...
        Debug.Log(a +" + " +  b  + " = " + c); //concatenate the string with integer and print to console...
        
        print(name + " " + surname); // we can also use print to console
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
