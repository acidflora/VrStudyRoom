using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class InputTest : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private ScenarioStepController _scnerioController;
    [SerializeField] private PlayerActionEventSender _playerActionEventSender;
    private Color _whiteColor;
    private Color _redColor;
    private int _counter;
    private string[] teststrings;
    private void Start()
    {
        _whiteColor = Color.white;
        _redColor = Color.red;
        teststrings = new string[] {TextHelper.ACTION, TextHelper.GRAB, TextHelper.WALK, TextHelper.ACTION};
    }
    private void OnEnable()
    {
        _playerActionEventSender.InputEvent += OnCompare;
    }
    private void OnDisable()
    {
        _playerActionEventSender.InputEvent -= OnCompare;
    }
    private void OnCompare(string value)
    {
        if (value == teststrings[_counter])
        {
            _counter++;
            if (_counter == 1)
                _scnerioController.GetCurrentScenarioStep().GetCurrentHelpInput().ShowGrabHelp();
            else if(_counter==2)
                _scnerioController.GetCurrentScenarioStep().GetCurrentHelpInput().ShowMovingHelp();
            else if(_counter==3)
                _scnerioController.GetCurrentScenarioStep().GetCurrentHelpInput().ShowActionHelp();
        }
        else
        {
            StartCoroutine(LightChanger());
        }
        if(_counter>3)
        {
            _scnerioController.GetCurrentScenarioStep().StartAction();
        }

    }
    private IEnumerator LightChanger()
    {
        _light.color = _redColor;
        yield return new WaitForSeconds(0.5f);
        _light.color = _whiteColor;
    }
}
