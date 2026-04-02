/*
* MenuSceneSystem.cs
* Gridventure Toolkit - Menu & Scene System
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
*   - Toggleable debug mode
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

/// <summary>
/// Handles simple scene transitions for a title scene and a gameplay scene.
/// Supports starting the game, returning to the title scene, and quitting the application.
/// Designed to be modular, beginner-friendly, and easy to expand.
/// </summary>
public class MenuSceneSystem : MonoBehaviour
{
    /// <summary>
    /// Defines how this script behaves in the current scene.
    /// Title -> The script is running in the title scene.
    /// Gameplay -> The script is running in the gameplay scene.
    /// </summary>
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

    /// <summary>
    /// Loads the configured gameplay scene.
    /// </summary>
    public void StartGame()
    {
        if (sceneConfig.InDebugMode)
        {
            Debug.Log("Loading Game Scene...");
        }

        SceneManager.LoadScene(sceneConfig.gameplaySceneName);
    }

    /// <summary>
    /// Loads the configured title scene.
    /// </summary>
    public void ReturnToTitle()
    {
        if (sceneConfig.InDebugMode)
        {
            Debug.Log("Returning to Title Scene...");
        }

        SceneManager.LoadScene(sceneConfig.titleSceneName);
    }

    /// <summary>
    /// Quits the application.
    /// In the Unity Editor, this stops Play Mode instead.
    /// </summary>
    public void QuitGame()
    {     
        if (sceneConfig.InDebugMode)
        {
            Debug.Log("Quitting Game...");
        }

        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
