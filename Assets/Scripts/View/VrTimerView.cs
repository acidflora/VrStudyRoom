using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
public class VrTimerView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;
    [SerializeField] private GameObject _hand;
    private void Awake()
    {
        transform.parent = _hand.transform;
        ModeController mode = FindObjectOfType<ModeController>();
        if (mode.IsDesktopMode())
            gameObject.SetActive(false);
    }
    public void SetTextOnCanvas(string text)
    {
        _textMesh.text = text;
    }

}
