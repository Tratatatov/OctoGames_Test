# (English) Middle Unity Developer Test

## 1.Coding Principles

1. **Single Responsibility Principle (SRP)**  
   New features and services can be added without breaking the overall project logic. Special attention is paid to separating data, visuals, and logic. For this purpose, MV (Model-View) approaches are used.

2. **Configuration Management**  
   Configurations have been moved into Scriptable Objects. Story text is parsed from writer-friendly formats.

## 2.Save/Load System

A simple system for saving and loading JSON files has been implemented. If necessary, it can be easily extended into a more robust solution.

## 3.Popup/UI System

A simple factory for popups has been created. This is a simplified version. If required, it can be further optimized by implementing object reuse instead of creating new instances each time.

### UI Components Used
- TextMeshPro, Image, Button, Canvas — standard Unity components
- Vertical/Horizontal Layout Group + Content Size Fitter — for automatic arrangement of UI elements

## 4.UI Performance & Refactoring

Two versions of the implementation were created:
- The first follows the suggested code structure.
- The second uses a cleaner approach with subscriptions to property value changes.

## 5.Gameplay and State Logic

- Object registration upon creation is handled via `EntityRegistry`.
- Object pooling has been implemented (especially useful for large numbers of entities).
- A Mediator pattern has been added for better code organization and decoupling.

## Optional Bonus Ideas

- Consider using **Zenject** for dependency injection.
- Utilize **DataProviders** to simplify work with large amounts of text and graphics.
- Set up ScriptableObjects and a custom text parser optimized for writers.
- Explore **Naninovel** (not yet used, but ready to learn).
- Perform optimization profiling using the Unity Profiler.

---

**P.S.**  
In this test task, the main focus was on making the code easily extendable and modifiable in the future. I am always ready to adapt to the existing architecture of the project.

# (Russian) Middle Unity Developer Тестовое

## 1.Coding Principles

1. **Раздреление обязанностей (Single Responsibility Principle — SRP)**  
  Мы сможем добавлять новые фичи и сервисы не ломая общую логику проекта. Так же важно разделять данные, визуал и логику. Для этого можно использовать MV подходы.

2. **Использование конфигов**  
   Вынесение конфигов в Scriptable Objects и парсинг текста (для сюжета) из удобных для писателей форматов.

## 2. Save/Load Utility

Я создал простую систему для записи файлов JSon. При необходимости можно сделать обертку, если понадобится более сложная система.

## 3.Popup/UI System

Я сделал простую фабрику для попапов. Она упрощенная, так же при необходимости можно не создавать, а переиспользовать один объект для оптимизации.

### Используемые UI-компоненты
- TextMeshPro, Image, Button, Canvas — стандартные компоненты 
- Vertical/Horizontal Layout Group + Content Size Fitter — для автоматического размещения и выравнивания элементов интерфейса

## 4.UI Performance & Refactoring

Я написал 2 варианта. 
 - Первый по аналогии с предложенным кодом
 - Второй с простой реализацией через подписку на изменение value в свойствах.

## 5.Gameplay/State Logic

- Реализовал регистрацию объектов при создании в EntityRegistry.
- Добавил пулинг объектов (так как в этом случае оно более логично, если мы имеем дело с большим количеством сущностей)
- Для чистоты кода добавил медиатор.

## Optional Bonus

- Возможно я бы сделал инициализацию через Zenject , использовал бы DataProviders, чтобы упростить работу с большим объемом текста и графики
- Настройка ScriptableObjects/кастомный парсер текста(для писателей)/использовать NaniNovel
- Через профайлер:)
---

**P.S.**  
В данном тестовом я отталкивался от идеи возможного расширения и модификации кода. В любом случае всегда подстраиваюсь под архитектуру проекта :)
