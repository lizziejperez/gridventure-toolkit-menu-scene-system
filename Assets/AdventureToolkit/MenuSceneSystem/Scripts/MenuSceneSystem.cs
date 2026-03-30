/*
* MenuSceneSystem.cs
* Adventure Toolkit - Menu & Scene System
* Version: 1.0
* 
* Author: Lizzie Perez
* Description:
* Handles simple scene transitions for a title and gameplay scene.
* Supports starting the game, returning to title, and quitting.
* Designed to be modular, beginner-friendly, and easy to expand.
* 
* Features:
*   - Enter to start game (Title Scene)
*   - Escape to quit (Title Scene)
*   - Space to return to title (Gameplay Scene)
*
* Future Expansion:
*   - UI button integration
*   - Scene transitions / loading screens
*   
*   Note:
*   Scene names must match exactily with Build Settings
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneSystem : MonoBehaviour
{
    // Defines how this script behaves in the current scene.
    public enum SceneRole
    {
        Title,
        Gameplay
    }

    [Header("Scene Role")]
    [SerializeField] private SceneRole sceneRole = SceneRole.Title;

    [Header("Scene System Configuration")]
    [SerializeField] private SceneSystemConfig sceneConfig;

    [Header("Input")]
    [SerializeField] private KeyCode startKey = KeyCode.Return;
    [SerializeField] private KeyCode quitKey = KeyCode.Escape; 
    [SerializeField] private KeyCode returnToTitleKey = KeyCode.Escape;

    void Update()
    {
        // Route input handling based on the scene role.
        switch (sceneRole)
        {
            case SceneRole.Title:
                HandleTitleInput();
                break;
            case SceneRole.Gameplay:
                HandleGameplayInput();
                break;
        }
    }

    private void HandleTitleInput()
    {
        // Start Game
        // Press Enter to load the gameplay scene.
        if (Input.GetKeyDown(startKey))
        { 
            StartGame();
        }

        // Quit Game
        // Press Escape to close the application.
        if (Input.GetKeyDown(quitKey))
        { 
            QuitGame();
        }
    }

    private void HandleGameplayInput()
    {
        // Return to Title
        // Press Space to go back to the title scene.
        if (Input.GetKeyDown(returnToTitleKey))
        {
            ReturnToTitle();
        }
    }

    public void StartGame()
    {
        // Loads the gameplay scene by name.
        Debug.Log("Loading Game Scene...");
        SceneManager.LoadScene(sceneConfig.gameplaySceneName);
    }

    public void ReturnToTitle()
    {
        // Loads the title scene by name.
        Debug.Log("Returning to Title Scene...");
        SceneManager.LoadScene(sceneConfig.titleSceneName);
    }

    public void QuitGame()
    {
        // Quits the application (works in builds).
        Debug.Log("Quitting Game...");
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
