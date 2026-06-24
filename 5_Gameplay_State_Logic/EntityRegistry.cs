using System;
using System.Collections.Generic;

public interface IGameplayEntity
{
    event Action<IGameplayEntity> OnDisabled;
    event Action<IGameplayEntity> OnDestroyed;
}

public class EntityRegistry
{
    private readonly HashSet<IGameplayEntity> _active = new();

    public HashSet<IGameplayEntity> Active => _active;

    public void Add(IGameplayEntity entity) => _active.Add(entity);
    public void Remove(IGameplayEntity entity) => _active.Remove(entity);
    public int Count => _active.Count;
}
