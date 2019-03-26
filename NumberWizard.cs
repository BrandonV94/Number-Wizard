using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems; // Namespace used to handle the button press issue.

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText; 

    int guess;

    void Start()
    {
        StartGame();
    }

    // Starts the game by choosing a random value from the NextGuess() function.
    void StartGame()
    {
        NextGuess();
    }

    // Sets the guessed value as the minimum and increases the value by 1.
    public void OnPressHigher()
    {
        min = guess +1;
        NextGuess();
    }

    // Sets the guessed value as the maximum and increases the value by 1.
    public void OnPressLower()
    {
        max = guess -1;
        NextGuess();
    }

    // Chooses a random value between the maximum and minimum and sets it to the guess value in the text field.
    void NextGuess()
    {
        guess = Random.Range(min,  max + 1);
        guessText.text = guess.ToString();
        // Turns off the highlighted button once the button is clicked.
        EventSystem.current.SetSelectedGameObject(null);
    }
}

