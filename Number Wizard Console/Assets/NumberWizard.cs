using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;
    

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("");
        Debug.Log("I am going to try to guess what number you're thinking of. Pick a number between " + min + " and " + max);
        Debug.Log("Did you think of one? Is your number higher or lower than " + guess + "?");
        Debug.Log("");
        Debug.Log("Press the UP ARROW if you're number is HIGHER.");
        Debug.Log("Press the DOWN ARROW if you're number is LOWER.");
        Debug.Log("Press the ENTER KEY if my guess is CORRECT.");
        max++; // solves the bug where the guess never reaches the maximum
    }


    // Update is called once per frame
    void Update()   
    {
        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("");
            Debug.Log("OK, so I guessed too low... Let me think");
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("");
            Debug.Log("OK, so I guessed too high... Let me think");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("");
            Debug.Log("YES!! I got it!");
            Debug.Log("");
            Debug.Log("Let's play again!");
            Debug.Log("");
            Debug.Log("");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("I have a new guess. Is your number " + guess + "?");
        Debug.Log("");
        Debug.Log("Press the UP ARROW if you're number is HIGHER.");
        Debug.Log("Press the DOWN ARROW if you're number is LOWER.");
        Debug.Log("Press the ENTER KEY if my guess is CORRECT.");
    }
}
