/*
* SceneSystemConfig.cs
* Gridventure Toolkit - Scene Configuration
* Version: 2.0
* Author: Lizzie Perez
*/
using UnityEngine;

/// <summary>
/// Stores shared scene names and debug settings used by the title and pause menu systems.
/// </summary>
/// <remarks>
/// Create this asset once and assign it to scene-related toolkit systems that need consistent scene references.
/// Scene name values must exactly match the names of scenes included in Build Settings.
/// </remarks>
[CreateAssetMenu(fileName = "SceneSystemConfig", menuName = "Gridventure Toolkit/Scene System Config")]
public class SceneSystemConfig : ScriptableObject
{
    [Header("Scene System Configuration Settings")]

    /// <summary>
    /// Name of the title scene to load when returning to the main menu.
    /// </summary>
    [SerializeField] public string titleSceneName;

    /// <summary>
    /// Name of the gameplay scene to load when starting the game from the title menu.
    /// </summary>
    [SerializeField] public string gameSceneName;

    [Header("Debug Mode Settings")]

    /// <summary>
    /// Enables additional debug logging for scene system input and transitions.
    /// </summary>
    [SerializeField] public bool inDebugMode = false;
}
