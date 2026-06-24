using UnityEngine;

public class PopupPresenter : MonoBehaviour
{
    [SerializeField] private PopupView _popupPrefab;
    [SerializeField] private PopupButton _buttonPrefab;
    [SerializeField] private Transform _popupParent;

    private PopupFactory _factory;
    private PopupView _currentPopup;

    private void Awake()
    {
        _factory = new PopupFactory(_popupPrefab, _buttonPrefab, _popupParent);
        _factory.Create("Hello Title", "Hello Body")
            .AddButton("Left button", () => Debug.Log("You clicked left button, congrats!"))
            .AddButton("Right button", () => Debug.Log("Oh, you clicked right"))
            .AddButton("Close", () => ClosePopup())
            .Show();
    }




    private void ClosePopup()
    {
        if (_currentPopup != null)
            _currentPopup.Hide();
    }
}
