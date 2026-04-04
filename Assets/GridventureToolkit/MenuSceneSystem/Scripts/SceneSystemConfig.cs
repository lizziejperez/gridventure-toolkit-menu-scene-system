/*
* SceneSystemConfig.cs
* Gridventure Toolkit - Scene Configuration
* Version: 2.0
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
    [Header("Scene System Configuration Settings")]
    [SerializeField] public string titleSceneName;
    [SerializeField] public string gameSceneName;

    [Header("Debug Mode Settings")]
    [SerializeField] public bool inDebugMode = false;
}
