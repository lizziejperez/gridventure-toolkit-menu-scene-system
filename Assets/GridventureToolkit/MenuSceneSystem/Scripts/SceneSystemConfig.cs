/*
* SceneSystemConfig.cs
* Gridventure Toolkit - Scene Configuration
* Version: 1.0
* 
* Author: Lizzie Perez
*/
using UnityEngine;

/// <summary>
/// Central configuration asset for scene names and shared settings used across scene-related systems such as menu and pause systems.
/// </summary>
/// <remarks>
/// Scene names must match exactily with Build Settings
/// </remarks>
[CreateAssetMenu(fileName = "SceneSystemConfig", menuName = "Gridventure Toolkit/Scene System Config")]
public class SceneSystemConfig : ScriptableObject
{
    [Header("Scene Names")]

    [Tooltip("Name of the title/menu scene")]
    public string titleSceneName = "TitleScene";

    [Tooltip("Name of the main gameplay scene")]
    public string gameplaySceneName = "GameplayScene";

    [Header("Debug Mode")]
    [SerializeField] private bool inDebugMode = false;

    /// <summary>
    /// Gets whether debug logging is enabled for the scene system.
    /// </summary>
    public bool InDebugMode => inDebugMode;
}
