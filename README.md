# (English) Middle Unity Developer Test

## Coding Principles

1. **Single Responsibility Principle (SRP)**  
   New features and services can be added without breaking the overall project logic. Special attention is paid to separating data, visuals, and logic. For this purpose, MV (Model-View) approaches are used.

2. **Configuration Management**  
   Configurations have been moved into Scriptable Objects. Story text is parsed from writer-friendly formats.

## Save/Load System

A simple system for saving and loading JSON files has been implemented. If necessary, it can be easily extended into a more robust solution.

## Popup/UI System

A simple factory for popups has been created. This is a simplified version. If required, it can be further optimized by implementing object reuse instead of creating new instances each time.

### UI Components Used
- TextMeshPro, Image, Button — standard Unity components
- Vertical/Horizontal Layout Group + Content Size Fitter — for automatic arrangement of UI elements

## UI Performance & Refactoring

Two versions of the implementation were created:
- The first follows the suggested code structure.
- The second uses a cleaner approach with subscriptions to property value changes.

## Gameplay and State Logic

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

## Принципы кодирования

1. **Принцип единственной ответственности (Single Responsibility Principle — SRP)**  
   Новые возможности и сервисы можно добавлять, не нарушая общую логику проекта. Особое внимание уделяется разделению данных, визуальной части и логики. Для этого используются подходы MV (Model-View).

2. **Управление конфигурациями**  
   Конфигурации вынесены в Scriptable Objects. Текст истории парсится из удобных для писателей форматов.

## Система сохранения/загрузки

Реализована простая система сохранения и загрузки JSON-файлов. При необходимости её можно легко расширить до более надёжного решения.

## Система попапов и UI

Создан простой фабричный класс для попапов. Это упрощённая версия. При необходимости её можно оптимизировать, внедрив переиспользование объектов вместо создания новых каждый раз.

### Используемые UI-компоненты
- TextMeshPro, Image, Button — стандартные компоненты Unity
- Vertical/Horizontal Layout Group + Content Size Fitter — для автоматического размещения элементов интерфейса

## Производительность UI и рефакторинг

Было создано две версии реализации:
- Первая следует предложенной структуре кода.
- Вторая использует более чистый подход с подпиской на изменения значений свойств.

## Игровая логика и состояние

- Реализована регистрация объектов при создании через `EntityRegistry`.
- Добавлен объектный пул (особенно актуально при большом количестве сущностей).
- Для лучшей организации кода использован паттерн Mediator.

## Дополнительные идеи

- Рассмотреть использование **Zenject** для внедрения зависимостей.
- Применить **DataProviders** для упрощения работы с большими объёмами текста и графики.
- Настроить ScriptableObjects и собственный парсер текста, удобный для писателей.
- Изучить **Naninovel** (пока не использовался, но готов изучить).
- Провести оптимизацию с помощью Unity Profiler.

---

**P.S.**  
В рамках тестового задания основной акцент был сделан на том, чтобы код был легко расширяемым и модифицируемым в будущем. Я всегда готов адаптироваться к существующей архитектуре проекта.
