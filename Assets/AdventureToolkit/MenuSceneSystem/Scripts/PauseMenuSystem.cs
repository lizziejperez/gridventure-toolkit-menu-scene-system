/*
* PauseMenuSystem.cs
* Adventure Toolkit - Pause Menu System
* Version: 1.0
* 
* Author: Lizzie Perez
* Description:
* Handles basic pause and resume functionality for a gameplay scene.
* Supports toggling a pause menu UI panel, freezing gameplay time,
* and returning to the title scene.
* 
* Features:
*   - Escape key toggles pause on and off
*   - Shows and hides a pause menu panel
*   - Freezes gameplay using Time.timeScale
*   - Supports returning to the title scene
*
* Future Expansion:
*   - UI button integration
*   - Scene transitions / loading screens
*   - Audio pause support
*   - Controller input support
*   
* Note:
*   - This system is intended for gameplay scenes, not title/menu scenes
*   - The pause panel should be assigned in the Inspector
*   - Time.timeScale is reset to 1 when resuming or leaving the scene
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuSystem : MonoBehaviour
{
    [Header("Pause UI")]
    [SerializeField] private GameObject pausePanel;

    [Header("Scene System Configuration")]
    [SerializeField] private SceneSystemConfig sceneConfig;

    // Tracks whether the game is currently paused
    // private bool isPaused = false;

    private void Start()
    {
        // TODO ResumeGame();
    }

    private void Update()
    {
        // Toggle pause when Escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // TODO TogglePause();
        }
    }
}