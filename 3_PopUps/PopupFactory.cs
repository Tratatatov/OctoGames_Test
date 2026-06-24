using System;
using System.Collections.Generic;
using UnityEngine;

public class PopupFactory
{
    private readonly PopupView _popupPrefab;
    private readonly PopupButton _buttonPrefab;
    private readonly Transform _parent;

    public PopupFactory(PopupView popupPrefab, PopupButton buttonPrefab, Transform parent)
    {
        _popupPrefab = popupPrefab;
        _buttonPrefab = buttonPrefab;
        _parent = parent;
    }

    public PopupBuilder Create(string title, string body)
    {
        return new PopupBuilder(_popupPrefab, _buttonPrefab, _parent, title, body);
    }
}

public class PopupBuilder
{
    private readonly PopupView _popupPrefab;
    private readonly PopupButton _buttonPrefab;
    private readonly Transform _parent;
    private readonly string _title;
    private readonly string _body;
    private readonly List<(string text, Action callback)> _buttons = new();

    public PopupBuilder(PopupView popupPrefab, PopupButton buttonPrefab, Transform parent, string title, string body)
    {
        _popupPrefab = popupPrefab;
        _buttonPrefab = buttonPrefab;
        _parent = parent;
        _title = title;
        _body = body;
    }

    public PopupBuilder AddButton(string text, Action callback)
    {
        _buttons.Add((text, callback));
        return this;
    }

    public PopupView Build()
    {
        if (_buttons.Count < 1 || _buttons.Count > 5)
            Debug.LogError($"PopupBuilder: некорректное количество кнопок ({_buttons.Count}). Допустимо от 1 до 5.");

        PopupView popup = GameObject.Instantiate(_popupPrefab, _parent); // TODO: Better use Pooling
        popup.gameObject.SetActive(false);
        popup.Initialize(_title, _body, _buttonPrefab, _buttons);
        return popup;
    }
}
