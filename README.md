1. Coding Principles:

1)Single Responsibility Principle (SRP)
We can add new features and services without breaking the overall project logic. It is also important to separate data, visuals, and logic. For this purpose, MV (Model-View) approaches can be used.
2)Configuration Management
Moving configurations into Scriptable Objects and parsing story text from writer-friendly formats.

2. Save/Load Utility
I created a simple system for saving and loading JSON files. If needed, it can be wrapped into a more robust system later.
3. Popup/UI System
I implemented a simple factory for popups. It is a simplified version; if necessary, we can optimize it further by reusing a single object instead of creating new ones.
3.1. UI Components Used:

TextMeshPro / Image / Button — Standard Unity components
Vertical/Horizontal Layout Group + Content Size Fitter — for automatically arranging UI elements

4. UI Performance & Refactoring
I made  two versions of the implementation. The first one follows the suggested code structure, while the second uses a cleaner approach with subscriptions to property value changes.
5. Gameplay/State Logic
I implemented object registration upon creation using an EntityRegistry. I also added object pooling (which makes sense when dealing with a large number of entities). For better code organization added a Mediator.
Optional Bonus Ideas:

- Possibly use Zenject for dependency injection. Utilize DataProviders to simplify working with large amounts of text and graphics.
- Set up ScriptableObjects / custom text parser (writer-friendly) / consider using Naninovel (I haven’t used it yet, but I’m ready to learn it).
- Profile optimization using the Unity Profiler:)

P.S. In this test task, I focused on the idea of making the code easily extendable and modifiable in the future.
In any case, I always adapt to the existing architecture of the project :)
