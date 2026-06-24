# Implementation Notes

**Unity Test Task — Code Architecture**

Clean, extensible and maintainable code architecture.

---

## 🎯 Core Principles

### 1. Single Responsibility Principle (SRP)
- Each class has a single, well-defined responsibility
- New features and services can be added without breaking existing logic
- Clear separation of **Data**, **Logic**, and **Visuals**
- Using **MV (Model-View)** approach

### 2. Configuration Management
- All configurations are moved to **ScriptableObjects**
- Story text is parsed from writer-friendly formats

---

## 🛠️ Implemented Systems

### Save/Load Utility
Simple and reliable system for saving and loading JSON files.  
Can be easily extended into a more robust solution if needed.

### Popup / UI System
- Implemented a simple factory for popups
- Simplified version (can be further optimized with object pooling if necessary)

#### UI Components Used:
- **TextMeshPro**
- **Image / Button** — standard Unity UI components
- **Vertical/Horizontal Layout Group** + **Content Size Fitter** — for automatic adaptive layout

---

## ⚡ UI Implementation & Refactoring

Two versions of the UI implementation were created:
1. First version follows the suggested code structure
2. Second version uses a cleaner approach with property change subscriptions

### Gameplay & State Logic
- **EntityRegistry** — automatic registration of objects upon creation
- **Object Pooling** — implemented for handling large numbers of entities
- **Mediator pattern** — added for better code organization and loose coupling

---

## 🚀 Optional Bonus Ideas

- Integrate **Zenject** for Dependency Injection
- Use **DataProviders** to simplify working with large amounts of text and graphics
- Custom text parser + ScriptableObjects (writer-friendly format)
- Consider **Naninovel** integration (visual novel framework)
- Performance profiling with **Unity Profiler**

---

## 📌 Project Focus

> In this test task, the main emphasis was placed on making the code **easily extendable and modifiable** in the future.

I am always ready to adapt to the existing architecture and coding standards of the project.

---

**Tech Stack:**
- Unity
- C#
- TextMeshPro
- ScriptableObjects
- JSON

---

*Clean Code • Good Architecture • Maintainability First*
