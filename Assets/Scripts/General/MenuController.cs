using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


// Credits to Brackeys for this pause menu: https://www.youtube.com/watch?v=JivuXdrIHK0
public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static bool GameIsPaused; // Static bool in case pause logic needs to be added.
    private Scene CurrentScene; // The scene you're currently in.
    private string CurrentSceneName; // The name of said scene.
    public GameObject PauseMenuUI; // The Pause menu UI.
    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene(); // grabs the current scene.
        CurrentSceneName = CurrentScene.name; // Sets string to the name of the scene.
        

    }

    private void OnEnable()
    {
        GameIsPaused = false;  // So no weird bugs occur upon reloading the scene or going back to the main menu.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) // If the game is running...
            {
                Resume(); 
            }

            else // otherwise...
            {
                Pause(); 
            }
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f; // ALlows time to move again
        SceneManager.LoadScene(CurrentSceneName); // Reloads the scene.

    }

    public void BackToMain()
    {
        Time.timeScale = 1f; // ALlows time to move again
        SceneManager.LoadScene("Loading Screen"); // Takes you to the title screen.
    }
    private void Pause()
    {
        PauseMenuUI.SetActive(true); // Enables the pause menu UI
        Time.timeScale = 0f; // Freezes time
        GameIsPaused = true; // Sets the game being paused to true
    }

    public void Resume()
    {
        
        PauseMenuUI.SetActive(false); // Disables the pause menu UI
        Time.timeScale = 1f; // Time starts moving again.
        GameIsPaused = false;  // Sets whether the game is paused or not to false.
    }

    public void QuitGame()
    {
        // Exits the game if built.
        Application.Quit(); 
    }
}
