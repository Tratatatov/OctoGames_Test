using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IGameplayEntity
{
    public event Action<IGameplayEntity> OnDisabled;
    public event Action<IGameplayEntity> OnDestroyed;

    public void Initialize(Vector3 position)
    {
        transform.position = position;
    }

    public void Die()
    {
        OnDisabled?.Invoke(this);
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        OnDestroyed?.Invoke(this);
    }
}
