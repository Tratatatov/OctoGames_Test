using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersView : MonoBehaviour

{
    [SerializeField] private List<Transform> _characters;

    void FixedUpdate() // TODO: This is for physics
    {
        float totalValue = 0f;

        foreach (Transform characterTransform in _characters)
        {
            Character character =
               characterTransform.gameObject.GetComponent<Character>(); //TODO: Need to cache, heavy operation
            totalValue += character != null ? character.Value : 0f;
        }

        string text = string.Format(
           "Characters: {0} Avg value: {1}",
           _characters.Count,
           _characters.Count / totalValue
        );

        gameObject.GetComponent<Text>().text = text; // //TODO: Need to cache, heavy operation
        Debug.Log(text);
    }
}


public class CharactersViewAlternative : MonoBehaviour
{
    [SerializeField] private Text _valueText;
    [SerializeField] private List<Character> _characters;
    [SerializeField] private float _checkInterval = 0.5f;

    private Coroutine _updateCoroutine;
    private bool _isPaused;

    private void OnEnable()
    {
        StartUpdateLoop();
    }

    private void OnDisable()
    {
        StopUpdateLoop();
    }

    public void StartUpdateLoop()
    {
        if (_updateCoroutine != null)
            StopCoroutine(_updateCoroutine);
        _updateCoroutine = StartCoroutine(UpdateLoop());
    }

    public void StopUpdateLoop()
    {
        if (_updateCoroutine != null)
        {
            StopCoroutine(_updateCoroutine);
            _updateCoroutine = null;
        }
    }

    public void SetPaused(bool paused) => _isPaused = paused;

    private IEnumerator UpdateLoop() //TODO: Update with fixed interval
    {
        while (true)
        {
            if (!_isPaused)
            {
                UpdateView();
            }

            yield return new WaitForSeconds(_checkInterval);
        }
    }

    private void UpdateView()
    {
        float totalValue = 0f;

        foreach (Character character in _characters)
        {
            totalValue += character != null ? character.Value : 0f;
        }

        string text = string.Format(
           "Characters: {0} Avg value: {1}",
           _characters.Count,
           _characters.Count / totalValue
        );

        _valueText.text = text;
        Debug.Log(text);
    }

}


