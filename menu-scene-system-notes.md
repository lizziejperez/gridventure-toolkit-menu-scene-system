# Menu & Scene System Notes

**Scripts**:

- SceneSystemConfig.cs
- TitleMenuSystem.cs
- PauseMenuSystem.cs

## Overview

A modular Unity (C#) system for handling simple scene transitions and menu interactions.

Designed to be:

* Beginner-friendly
* Plug-and-play
* Easy to extend for additional systems (UI menus, loading screens, etc.)

## Scenes & Menus

The system is built around three core states:

* **Title Scene** – entry point of the game
* **Gameplay Scene** – main playable scene
* **Pause Menu** – overlay within the gameplay scene

## System Breakdown

### Title Menu Logic

* **Confirm (Enter)** → Load Gameplay Scene
* **Cancel (Escape)** → Quit Application

### Pause Menu Logic

* **Cancel (Escape)** → Toggle Pause / Resume
* **Confirm (Enter)** → Return to Title Scene *(only when paused)*

## Design Decisions

* **Scene Loading**
  * Uses `SceneManager.LoadScene` for simplicity
  * Can be upgraded to `SceneManager.LoadSceneAsync` for loading screens
* **Scene Identification**
  * Uses **scene names** instead of build indices
  * Easier to understand and integrate into different projects
* **Input System**
  * Uses Unity’s **New Input System**
  * Actions are based on intent:
    * `Confirm`
    * `Cancel`
* **Configuration**
  * Uses a `ScriptableObject` (`SceneSystemConfig`)
  * Centralizes:
    * scene names
    * debug settings

## Resources Used
Primarily referenced the official Unity documentation and notes.

* Unity SceneManager Documentation:
  https://docs.unity3d.com/6000.3/Documentation/ScriptReference/SceneManagement.SceneManager.html
* Unity Time.timeScale Documentation: https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Time-timeScale.html