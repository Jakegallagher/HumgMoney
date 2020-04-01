using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int guess;
    int max;
    int min;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("what is up motherfuckers!");
        Debug.Log("I am teh Numb3rwizard");
        Debug.Log("choose a number");
        Debug.Log("maximum of " + max);
        Debug.Log("minimum of " + min);
        Debug.Log("is it higher or lower than " + guess);
        Debug.Log("up arrow = higher, down arrow = lower, enter = correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct answer! The Numb3rwizard has spoken");
            StartGame();
        }
    }
    void NextGuess()
    {
        Debug.Log("is it higher or lower than " + guess);
        Debug.Log("up arrow = higher, down arrow = lower, enter = correct");
    }
}
