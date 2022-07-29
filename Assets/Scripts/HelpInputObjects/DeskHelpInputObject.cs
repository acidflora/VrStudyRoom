using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _keyboard;
    [SerializeField] private GameObject _mouse;
    [SerializeField] private ColorChanger _leftM;   
    [SerializeField] private ColorChanger _rightM;
    [SerializeField] private ColorChanger _midM;
    [SerializeField] private ColorChanger _w;
    [SerializeField] private ColorChanger _a;
    [SerializeField] private ColorChanger _s;
    [SerializeField] private ColorChanger _d;
    [SerializeField] private ColorChanger _esc;

    public override void ShowMovingHelp()
    {
        _keyboard.SetActive(true);
        _mouse.SetActive(true);
        HideAllBlinks();
        _midM.ControlBlink(true);
        _w.ControlBlink(true);
        _a.ControlBlink(true);
        _s.ControlBlink(true);
        _d.ControlBlink(true);
     }
    public override void ShowActionHelp()
    {
        _mouse.SetActive(true);
        HideAllBlinks();
        _leftM.ControlBlink(true);
    }
    public override void ShowGrabHelp()
    {
         _mouse.SetActive(true);
        HideAllBlinks();
        _rightM.ControlBlink(true);
    }
    public override void ShowMenuHelp()
    {
      
        _keyboard.SetActive(true);
        HideAllBlinks();
        _esc.ControlBlink(true);
    }
    public override void Hide()
    {
        _keyboard.SetActive(false);
        _mouse.SetActive(false);
    }
    public override void ShowInput()
    {
    
        _keyboard.SetActive(true);
        _mouse.SetActive(true);
        HideAllBlinks();
        _midM.ControlBlink(true);
        _w.ControlBlink(true);
        _a.ControlBlink(true);
        _s.ControlBlink(true);
        _d.ControlBlink(true);
        _leftM.ControlBlink(true);
        _rightM.ControlBlink(true);
    }
    public override void HideAllBlinks()
    {
        _midM.ControlBlink(false);
        _w.ControlBlink(false);
        _a.ControlBlink(false);
        _s.ControlBlink(false);
        _d.ControlBlink(false);
        _leftM.ControlBlink(false);
        _rightM.ControlBlink(false);
        _esc.ControlBlink(false);
    }
}
