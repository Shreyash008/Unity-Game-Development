using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start() 
    {
        
        Debug.Log("Welcome to Number Wizard, Yo");
        Debug.Log("Pick a Number, shhh don't tell me anything...");
        Debug.Log("Highest number to pick from is " + max);
        Debug.Log("Lowest number to pick from is " + min);
        Debug.Log("Tell me if your number is Higher or Lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Correct = Enter");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed.");
            max = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
