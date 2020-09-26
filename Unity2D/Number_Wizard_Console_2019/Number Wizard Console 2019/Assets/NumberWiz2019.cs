using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWiz2019 : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    int guess = 500;
    void Start()
    {
        Debug.Log("I welcometh thee to the w'rld of gaming");
        Debug.Log("Enter your lucky number ...shh don't tell it to me");
        Debug.Log("The maximum limit you can choose from is " + max);
        Debug.Log("The minimum limit you can choose from is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Higher = Push Up Arrow key, Lower = Push Down Arrow Key, Correct = Push Enter");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Talk about EAZY.");
        }
    }
}
