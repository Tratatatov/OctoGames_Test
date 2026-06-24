using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : Component
{
    private readonly T _prefab;
    private readonly Transform _parent;
    private readonly Stack<T> _pool = new();

    public ObjectPool(T prefab, Transform parent = null)
    {
        _prefab = prefab;
        _parent = parent;
    }

    public T Get()
    {
        if (_pool.Count > 0)
        {
            var obj = _pool.Pop();
            obj.gameObject.SetActive(true);
            return obj;
        }

        return Object.Instantiate(_prefab, _parent);
    }

    public void Release(T obj)
    {
        obj.gameObject.SetActive(false);
        _pool.Push(obj);
    }

    public void Prewarm(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var obj = Object.Instantiate(_prefab, _parent);
            obj.gameObject.SetActive(false);
            _pool.Push(obj);
        }
    }
}
