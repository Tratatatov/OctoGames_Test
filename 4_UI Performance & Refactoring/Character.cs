using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public event Action<float> OnValueChanged;

    private float _value;
    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(_value);
        }
    }

    private void Start()
    {
        SetRandomValue();
    }

    private void SetRandomValue()
    {
        _value = UnityEngine.Random.Range(1f, 100f);
    }
}
