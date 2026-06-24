using System;
using System.Collections.Generic;

public class EntityMediator
{
    private readonly EntityRegistry _registry = new();

    public event Action<IGameplayEntity> OnEntityRegistered;
    public event Action<IGameplayEntity> OnEntityDisabled;
    public event Action<IGameplayEntity> OnEntityDestroyed;

    public void Register(IGameplayEntity entity)
    {
        _registry.Add(entity);
        entity.OnDisabled += HandleDisabled;
        entity.OnDestroyed += HandleDestroyed;
        OnEntityRegistered?.Invoke(entity);
    }

    public int ActiveCount => _registry.Count;

    private void HandleDisabled(IGameplayEntity entity)
    {
        _registry.Remove(entity);
        entity.OnDisabled -= HandleDisabled;
        entity.OnDestroyed -= HandleDestroyed;
        OnEntityDisabled?.Invoke(entity);
    }

    private void HandleDestroyed(IGameplayEntity entity)
    {
        _registry.Remove(entity);
        entity.OnDisabled -= HandleDisabled;
        entity.OnDestroyed -= HandleDestroyed;
        OnEntityDestroyed?.Invoke(entity);
    }
}
