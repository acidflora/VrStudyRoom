using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private float _time = 1;
    private Color _changedColor;
    private Color _baseColor;
    private bool _blink = false;
    void Awake()
    {
        _baseColor = GetComponent<Renderer>().material.color;
        _baseColor.a = 0;
        _changedColor = Color.green;
        _changedColor.a = 255;
    }
    void Update()
    {
        if (_blink)
        {
            _time += Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.Lerp(_changedColor, _baseColor, Mathf.PingPong(_time * 2, 1));

            if (_time >= 1)
            {
                _time = 0;
            }
        }
        else
            GetComponent<Renderer>().material.color = _baseColor;


    }
    public void ControlBlink(bool value)
    {
        _blink = value;
    }
}
