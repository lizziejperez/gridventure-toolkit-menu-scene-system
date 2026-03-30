/*
* SceneSystemConfig.cs
* Adventure Toolkit - Scene Configuration
* 
* Author: Lizzie Perez
* Description:
* Central configuration asset for scene names used across systems
* such as MenuSceneSystem and PauseMenuSystem.
*/
using UnityEngine;

[CreateAssetMenu(fileName = "SceneSystemConfig", menuName = "Adventure Toolkit/Scene System Config")]
public class SceneSystemConfig : ScriptableObject
{
    [Header("Scene Names")]

    [Tooltip("Name of the title/menu scene")]
    public string titleSceneName = "TitleScene";

    [Tooltip("Name of the main gameplay scene")]
    public string gameplaySceneName = "GameplayScene";
}
