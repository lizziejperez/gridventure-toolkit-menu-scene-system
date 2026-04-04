/*
* MenuSceneSystem.cs
* Gridventure Toolkit - Menu & Scene System
* Version: 2.0
* Author: Lizzie Perez
*/

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles simple scene transitions for a title/menu scene.
/// Supports starting the game and quitting the application.
/// </summary>
/// <remarks>
/// Requires PlayerInput component
/// </remarks>
[RequireComponent(typeof(PlayerInput))]
public class MenuSceneSystem : MonoBehaviour
{
    [Header("Title Menu Settings")]
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
