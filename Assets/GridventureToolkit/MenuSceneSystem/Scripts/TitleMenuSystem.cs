/*
* TitleMenuSystem.cs
* Gridventure Toolkit - Title Menu System
* Version: 2.0
* Author: Lizzie Perez
*/

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls title menu input for starting the game or quitting the application.
/// </summary>
/// <remarks>
/// Attach this component to a GameObject in the title scene.
/// Requires a PlayerInput component on the same GameObject.
/// Expects the assigned Input Actions asset to contain:
/// 1. Confirm - used to load the gameplay scene.
/// 2. Cancel - used to quit the application.
/// Scene names are read from the assigned SceneSystemConfig.
/// </remarks>
[RequireComponent(typeof(PlayerInput))]
public class TitleMenuSystem : MonoBehaviour
{
    [Header("Title Menu Settings")]

    /// <summary>
    /// Shared configuration asset containing scene names and debug settings.
    /// </summary>
    [SerializeField] private SceneSystemConfig config;

    private PlayerInput menuInput;
    private InputAction confirmAction, cancelAction;

    // Initialization

    private void Awake()
    {
        menuInput = GetComponent<PlayerInput>();
        confirmAction = menuInput.actions["Confirm"];
        cancelAction = menuInput.actions["Cancel"];
    }

    private void OnEnable()
    {
        confirmAction.started += LoadGameScene;
        cancelAction.started += QuitGame;
    }

    // Helper methods for Player Input
    
    private void RemoveEvents()
    {
        confirmAction.started -= LoadGameScene;
        cancelAction.started -= QuitGame;
    }

    private void LoadGameScene(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("LoadGameScene called!\nContext: " + callbackContext);
        }

        RemoveEvents();
        SceneManager.LoadScene(config.gameSceneName);
    }

    private void QuitGame(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("QuitGame called!\nContext: " + callbackContext);
        }

        // Close game
        RemoveEvents();
        Application.Quit();

        // Close Unity play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // Decommisioning
    private void OnDisable()
    {
        RemoveEvents();
    }
}
