/*
* SceneSystemConfig.cs
* Gridventure Toolkit - Scene Configuration
* 
* Author: Lizzie Perez
* Description:
* Central configuration asset for scene names used across systems
* such as MenuSceneSystem and PauseMenuSystem.
*/
using UnityEngine;

/// <summary>
/// Central configuration asset for scene names and shared settings used across scene-related systems such as menu and pause systems.
/// </summary>
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
