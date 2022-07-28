using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _keyboard;
    [SerializeField] private GameObject _mouse;

    public override void ShowMovingHelp()
    {
        base.ShowMovingHelp();
        _keyboard.SetActive(true);
        _mouse.SetActive(true);
    }
    public override void ShowActionHelp()
    {
        base.ShowActionHelp();
        _mouse.SetActive(true);
    }
    public override void ShowGrabHelp()
    {
        base.ShowGrabHelp();
        _mouse.SetActive(true);
    }
    public override void ShowMenuHelp()
    {
        base.ShowMenuHelp();
        _keyboard.SetActive(true);
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
        walkingDots.SetActive(true);
        actionDots.SetActive(true);
        grabDots.SetActive(true);
    }
}
