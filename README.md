# Gridventure Toolkit: Menu & Scene System (Unity C#)

A reusable, adventure game–style menu and scene management system built in Unity using C#.

This project is part of the **Gridventure Toolkit series**, focused on creating modular, beginner-friendly systems that can be easily integrated into Unity projects.

**Current Version**: v1.0

## Overview

This system gives you a simple foundation for:

* Title screen → Gameplay flow
* Scene transitions using a centralized config
* Clean, reusable menu logic

Designed to be **plug-and-play**, easy to understand, and easy to extend.

## Features (v1.0)

Menu Scene System

* Start game from title screen
* Quit game functionality
* Return to title from gameplay

Scene System Config (Scriptable Object)

* Centralized location for scene names
* Avoids hardcoding scene strings across scripts
* Easy to modify without touching code
* Optional debug mode toggle

Clean C# Architecture

* Separated responsibilities between systems
* Beginner-friendly and readable scripts
* Designed for extension (pause, settings, etc.)

## Planned Features (v1.1)

Pause Menu System
* Toggle pause
* Resume gameplay
* Return to title from pause menu
* Use 'Time.timeScale' for pause control

Note: The pause system is currently in development and will be included in the next release.

## Demo Scenes Included

The project will include:

* **TitleScene**
  * Basic menu UI
  * Start and quit functionality
* **GameScene**
  * Example environment

## Setup & Usage

### 1. Add Scenes to Build Settings

* Open **File → Build Settings**
* Add your scenes:
  * Title Scene
  * Game / Demo Scene

### 2. Create Scene System Config

* Right-click in Project → **Create → Scene System Config**
* Assign:
  * Title Scene Name
  * Game Scene Name
* (Optional) Enable **Debug Mode**

### 3. Press Play

* Start from the Title Scene
* Press **Enter** → loads Game Scene
* Press **Escape (Esc)** → returns to Title or quits

## Demo Controls & Customization

The current version (v1.0) uses simple keyboard input for scene transitions:

* **Enter** → Start Game
* **Escape (Esc)** → Return to Title / Quit

These controls are included for demonstration and quick testing.

### Customizing Input

You can change this behavior in the `MenuSceneSystem` script:

* Replace the key checks with your own input logic
* Connect UI buttons (planned for future versions)
* Integrate Unity’s Input System if desired

This system is designed to be flexible — use whatever input method fits your project.

## Project Structure

```
Assets/GridventureToolkit/
├── MenuSceneSystem/
│   ├── Scripts/
│   ├── Prefabs/
│   ├── Scenes/
│   └── Fonts/
├── Demo/
│   ├── Prefabs/
│   └── Scenes/
└── Art/
```

## What This System Demonstrates

* Scene management using Unity’s `SceneManager`
* Use of Scriptable Objects for configuration
* Clean project structure and modular design

## Design Goals

* Beginner-friendly and easy to follow
* Minimal setup required
* Modular and reusable
* Clean separation of logic and configuration
* Consistent with other Gridventure Toolkit systems

## Future Improvements

* Settings menu (audio, controls)
* Scene transition effects (fade in/out)
* Controller / new Input System support
* Save/load system integration


## Part of the Gridventure Toolkit Series

This system is designed to work alongside:

* Top-Down Movement System
* Future systems (tiling systems, interaction systems, etc.)

## 💼 Freelance & Support

Need help customizing or extending this system?

I offer freelance help for Unity and game development:
[https://www.fiverr.com/lizziejperez](https://www.fiverr.com/lizziejperez)
