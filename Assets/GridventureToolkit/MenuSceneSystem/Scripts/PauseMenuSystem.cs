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
/// Handles pause menu behavior during gameplay, including pausing, resuming,
/// displaying a pause panel, and returning to the title scene.
/// </summary>
/// <remarks>
/// Attach this component to a GameObject in the gameplay scene.
/// Requires a PlayerInput component on the same GameObject.
/// Expects the assigned Input Actions asset to contain:
/// 1. Confirm - toggles the pause state on and off.
/// 2. Cancel - returns to the title scene while paused.
/// Also requires a pause panel GameObject that can be enabled and disabled to visually indicate the pause state.
/// </remarks>
[RequireComponent(typeof(PlayerInput))]
public class PauseMenuSystem : MonoBehaviour
{
    [Header("Pause Menu Settings")]

    /// <summary>
    /// Shared configuration asset containing scene names and debug settings.
    /// </summary>
    [SerializeField] private SceneSystemConfig config;

    /// <summary>
    /// UI panel shown while the game is paused.
    /// This object is enabled when paused and disabled when gameplay resumes.
    /// </summary>
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
        pausePanel.SetActive(false); // ensure pause panel is not active
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
            pausePanel.SetActive(false); // Disable the pause panel
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