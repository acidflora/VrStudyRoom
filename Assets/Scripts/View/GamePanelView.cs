using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePanelView : MonoBehaviour
{
    public static GamePanelView Instance;
    private GamePanelView() {}
    private void Awake()
    {
        if(Instance == null)
            Instance = this; 
    }
    [SerializeField] private TextMeshProUGUI _header;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private TextMeshProUGUI _actionText;
    [SerializeField] private GameObject _actionTextObject;
    public void SetHeaderText(string text)
    {
        _header.text= text;
    }
    public void SetDescriptionText(string text)
    {
        _descriptionText.text = text;
    }
    public void SetActionText(string text)
    {
        _actionText.text = text;
    }
    public void EnableActionTextObject(bool value)
    {
        _actionTextObject.SetActive(value);
    }
}
