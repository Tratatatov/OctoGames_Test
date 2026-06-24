using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _titleText;
    [SerializeField] private Button _button;

    private Action _callback;

    public void Initialize(string titleText, Action callback)
    {
        _titleText.text = titleText;
        _callback = callback;
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick() => _callback?.Invoke();

    private void OnDisable() => _button.onClick.RemoveListener(OnClick);

}
