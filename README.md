# Gridventure Toolkit: Menu & Scene System (Unity C#)

**Current Version:** v2.0

<!-- Demo Video: -->

A reusable, modular menu and scene management system built with Unity’s **New Input System**, designed for clarity, flexibility, and easy integration.

Built in Unity with C#, this beginner-friendly system provides a clean foundation for handling **title menus, gameplay transitions, and pause functionality** across both 2D and 3D projects.

Includes ready-to-use prefabs and demo scenes for quick setup and testing.

## Features

### v2.0

* Title menu system (start game / quit)
* Pause menu system (pause, resume, return to title)
* Centralized scene configuration using `ScriptableObject`
* Built with Unity’s **New Input System**
* Input actions based on intent (`Confirm`, `Cancel`)
* Uses `PlayerInput` with event-driven callbacks
* Toggle pause using `Time.timeScale`
* Pause panel UI support (enable/disable)
* Clean, modular C# architecture
* Ready-to-use prefabs for quick setup
* Demo scenes included for testing and integration

## Who It’s For

Perfect for:

* Beginners learning Unity scene flow and menus
* Developers building reusable game systems
* Rapid prototyping of game structure

Use this as a foundation for your own projects.

## Controls

### Title Scene

* Enter / Space — Start Game
* Escape — Quit Game

### Gameplay (Pause System)

* Escape — Pause / Resume
* Enter / Space — Return to Title (while paused)

## How to Use

### Quick Start

1. Open the project in Unity (tested with Unity 6 LTS)
2. Open the **Title Scene**
3. Press Play

### Setup

#### 1. Add Scenes to Build Settings

* Open **File → Build Settings**
* Add:
  * Title Scene
  * Gameplay Scene

#### 2. Create Scene System Config

* Right-click in Project → **Create → Gridventure Toolkit → Scene System Config**
* Assign:
  * Title Scene Name
  * Game Scene Name
* (Optional) Enable **Debug Mode**

#### 3. Add Prefabs

Title Scene:

* Add `TitleMenuSystem` prefab to the scene
* Assign your created **SceneSystemConfig** to the prefab in the Inspector

Gameplay Scene:

* Add `PauseMenuSystem` prefab to the scene
* Assign your created **SceneSystemConfig** to the prefab
* Assign a **Pause Panel** GameObject (UI panel to show when paused)


## Input System Reference

This project uses Unity’s **New Input System**.

For more information:
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.6/manual/index.html

## Project Structure

```
Assets/GridventureToolkit/
├── MenuSceneSystem/
│   ├── Input/
│   ├── Scripts/
│   └── Prefabs/
├── Demo/
│   ├── Fonts/
│   ├── Prefabs/
│   └── Scenes/
└── Art/
```

## System Flow

### Title Menu

```
Confirm → Load Gameplay Scene
Cancel → Quit Game
```

### Pause Menu

```
Escape → Toggle Pause
Confirm → Return to Title (when paused)
```

## Technical Notes

* Requires `PlayerInput` component
* Uses Unity’s New Input System
* Uses event-based input callbacks
* Uses `SceneManager.LoadScene` for transitions
* Uses `Time.timeScale` for pause functionality
* Designed to work in both 2D and 3D projects

## What This System Demonstrates

* Scene management using Unity’s `SceneManager`
* Input handling with Unity’s New Input System
* State-based input switching (gameplay vs pause)
* ScriptableObject-based configuration
* Modular, reusable system design
* Prefab-based workflow for easy integration

## Future Improvements

* Settings menu (audio, controls)
* Scene transition effects (fade in/out)
* Controller / new Input System support
* Save/load system integration

## Additional Notes

For a deeper breakdown of system behavior and design decisions, see:

[menu-scene-system-notes.md](menu-scene-system-notes.md)

## Previous Version Demo (v1.0)

Demo Video: [https://youtu.be/lWFx60s125k](https://youtu.be/lWFx60s125k)

## 💼 Freelance & Support

Need help customizing or extending this system?

I offer freelance help for Unity and game development:
[https://www.fiverr.com/lizziejperez](https://www.fiverr.com/lizziejperez)