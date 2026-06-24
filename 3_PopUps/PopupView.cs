using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private TextMeshProUGUI _bodyText;
    [SerializeField] private Transform _buttonsContainer;

    public void Initialize(string title, string body, PopupButton buttonPrefab, List<(string text, Action callback)> buttons)
    {
        _titleText.text = title;
        _bodyText.text = body;

        foreach ((string text, Action callback) in buttons)
        {
            PopupButton button = Instantiate(buttonPrefab, _buttonsContainer); //TODO: Better use Pooling
            button.Initialize(text, callback);
        }
    }

    public void Show() => gameObject.SetActive(true); // TODO: Can add animation, Pooling, etc.


    public void Hide() => gameObject.SetActive(false); // TODO: Can add animation, Pooling, etc.

}
