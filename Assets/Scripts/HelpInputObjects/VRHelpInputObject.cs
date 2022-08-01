using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _htc;
    [SerializeField] private GameObject _handWatch;
    [SerializeField] private ColorChanger _kurok;
    [SerializeField] private ColorChanger _joystick;
    [SerializeField] private ColorChanger _bigButton;
    [SerializeField] private ColorChanger _watch;

    public override void ShowMovingHelp()
    {
        _htc.SetActive(true);
        HideAllBlinks();
        _joystick.ControlBlink(true);
    }
    public override void ShowActionHelp()
    {
        _htc.SetActive(true);
        HideAllBlinks();
        _kurok.ControlBlink(true);
    }
    public override void ShowGrabHelp()
    {
        _htc.SetActive(true);
        HideAllBlinks();
        _bigButton.ControlBlink(true);
    }
    public override void ShowMenuHelp()
    {
        _htc.SetActive(true);
        _handWatch.SetActive(true);
        HideAllBlinks();
        _kurok.ControlBlink(true);
        _watch.ControlBlink(true);
 
    }
    public override void Hide()
    {
        HideAllBlinks();
        _htc.SetActive(false);
        _handWatch.SetActive(false);
    }
    public override void ShowInput()
    {
         HideAllBlinks();
        _htc.SetActive(true);
    }
    public override void HideAllBlinks()
    {
        _kurok.ControlBlink(false);
        _joystick.ControlBlink(false);
        _bigButton.ControlBlink(false);
        _watch.ControlBlink(false);
    }

}
