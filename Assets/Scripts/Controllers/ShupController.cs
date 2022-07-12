using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ShupController : MonoBehaviour
{
    public UnityAction<string> SetMeasureTextEvent;

    [SerializeField] private GameObject _redShup;
    [SerializeField] private GameObject _blackShup;
    [HideInInspector] public bool CanMeasure = true;

    private bool _firstMeasure = false;
    public string measureText;

    public string SetShupPosition(Transform newPos, string text)
    {
        if (CanMeasure)
        {
            if (!_firstMeasure)
            {
                if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
                {
                    _redShup.transform.position = newPos.position;
                    _redShup.transform.rotation = Quaternion.Euler(20, 0, 0);
                    _firstMeasure = true;
                    measureText = text;
                    SetMeasureTextEvent?.Invoke(measureText);

                }
                else if (_redShup.transform.position == newPos.position)
                {
                    _redShup.transform.position = Vector3.zero;
                }
                else if (_blackShup.transform.position == newPos.position)
                {
                    _blackShup.transform.position = Vector3.zero;
                    _firstMeasure = true;
                }
            }
            else if (_firstMeasure)
            {
                if (_redShup.transform.position != newPos.position && _blackShup.transform.position != newPos.position)
                {
                    _blackShup.transform.position = newPos.position;
                    _blackShup.transform.rotation = Quaternion.Euler(20, 0, 0);
                    _firstMeasure = false;
                    measureText += " " + text;
                    SetMeasureTextEvent?.Invoke(measureText);

                }

                else if (_blackShup.transform.position == newPos.position)
                {
                    _blackShup.transform.position = Vector3.zero;
                }
                else if (_redShup.transform.position == newPos.position)
                {
                    _redShup.transform.position = Vector3.zero;
                    _firstMeasure = false;
                }
            }
            if (_redShup.transform.position == Vector3.zero && _blackShup.transform.position == Vector3.zero)
                _firstMeasure = false;
        }

        return measureText;
    }

    public void ResetShupPosition()
    {
        _redShup.transform.position = Vector3.zero;
        _blackShup.transform.position = Vector3.zero;
        measureText = "";
        SetMeasureTextEvent?.Invoke("");
        _firstMeasure = false;
    }
    public bool ReturnMeasure()
    {
        return _firstMeasure;
    }
}
