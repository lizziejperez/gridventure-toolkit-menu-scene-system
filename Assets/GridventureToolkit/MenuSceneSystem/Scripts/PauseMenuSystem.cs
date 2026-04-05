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
/// Requires PlayerInput component and a pause panel
/// </remarks>
[RequireComponent(typeof(PlayerInput))]
public class PauseMenuSystem : MonoBehaviour
{
    [Header("Pause Menu Settings")]
    [SerializeField] private SceneSystemConfig config;
    [SerializeField] private GameObject pausePanel;

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
        cancelAction.started += TogglePause;
    }

    // Helper methods for Player Input
    
    private void TogglePause(InputAction.CallbackContext callbackContext)
    {
        if (config.inDebugMode)
        {
            Debug.Log("TogglePause called!\nContext: " + callbackContext);
        }

        if (gameIsPaused)
        {
            pausePanel.SetActive(false); // Disable the Pause Panel
            Time.timeScale = 1.0f; // Un-pause game time            
            confirmAction.started -= ReturnToTitle; // Update input functionality
            gameIsPaused = false; // update flag
        }
        else
        {
            pausePanel.SetActive(true); // Enable the Pause Panel
            Time.timeScale = 0.0f; // Pause game time            
            confirmAction.started += ReturnToTitle; // Update input functionality
            gameIsPaused = true; // update flag
        }
    }

    private void RemoveEvents()
    {
        if (gameIsPaused)
        {
            confirmAction.started -= ReturnToTitle;
        }
        cancelAction.started -= TogglePause;
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

    // Decommisioning
    private void OnDisable()
    {
        RemoveEvents();
    }
}