using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersViewFixed : MonoBehaviour
{
    [SerializeField] private List<Character> _characters;
    [SerializeField] private Text _text;

    private void OnEnable()
    {
        foreach (Character character in _characters)
            character.OnValueChanged += OnCharacterValueChanged;
    }

    private void OnDisable()
    {
        foreach (Character character in _characters)
            character.OnValueChanged -= OnCharacterValueChanged;
    }

    private void OnCharacterValueChanged(float _) => UpdateText();

    private void UpdateText()
    {
        if (_characters.Count == 0)
            return;

        float totalValue = 0f;
        foreach (Character character in _characters)
            totalValue += character.Value;

        _text.text = $"Characters: {_characters.Count} Avg value: {totalValue / _characters.Count:F1}";
    }
}
