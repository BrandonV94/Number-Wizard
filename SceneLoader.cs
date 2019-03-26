using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Loads the next scene using the current scene index value.
    public void LoadNextScene()
    {
        // Create a variable to save the current scene index.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Have the scene manager load the next game scene by adding one to the current scene index.
        SceneManager.LoadScene(currentSceneIndex + 1);

    }

    // Loads the start scene by passing in the value 0.
    public void LoadStartScene()
    {
        // Load the very first scene in our game. Index 0 is the start game menu scene.
        SceneManager.LoadScene(0);
    }

    // Allows the user to close and quit the application using an in game button.
    public void QuitGame()
    {
        Application.Quit();
    }
}
