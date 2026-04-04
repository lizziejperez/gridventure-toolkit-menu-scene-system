/*
* PauseMenuSystem.cs
* Gridventure Toolkit - Pause Menu System
* Version: 2.0
* Author: Lizzie Perez
*/

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles simple scene transitions and pause toggle for a gameplay scene.
/// </summary>
/// <remarks>
/// Requires PlayerInput component
/// </remarks>
[RequireComponent(typeof(PlayerInput))]
public class PauseMenuSystem : MonoBehaviour
{
    [Header("Pause Menu Settings")]
    [SerializeField] private SceneSystemConfig config;

    private bool gameIsPaused;
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
        gameIsPaused = false;
        cancelAction.started += PauseGame;
    }

    // Helper methods for Player Input

    private void RemoveEvents()
    {
        if (gameIsPaused)
        {
            cancelAction.started -= ReturnToTitle;
        }
        else
        {
            cancelAction.started -= PauseGame;
        }
    }

    private void PauseGame(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("PauseGame called!\nContext: " + callbackContext);
        }

        // TODO: pause game time and update functionality
        gameIsPaused = true;
        cancelAction.started -= PauseGame;
        cancelAction.started += ReturnToTitle;
        confirmAction.started += UnPauseGame;
    }

    private void ReturnToTitle(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("ReturnToTitle called!\nContext: " + callbackContext);
        }

        RemoveEvents();
        SceneManager.LoadScene(config.titleSceneName);
    }

    private void UnPauseGame(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("UnPauseGame called!\nContext: " + callbackContext);
        }

        // TODO: un-pause game time and update functionality
        gameIsPaused = false;
        cancelAction.started -= ReturnToTitle;
        confirmAction.started -= UnPauseGame;
        cancelAction.started += PauseGame;        
    }

    // Decommisioning
    private void OnDisable()
    {
        RemoveEvents();
    }
}