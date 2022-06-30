using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _htc;
    [SerializeField] private GameObject _handWatch;
    public override void ShowMovingHelp()
    {
        base.ShowMovingHelp();
        _htc.SetActive(true);
    }
    public override void ShowActionHelp()
    {
        base.ShowActionHelp();
        _htc.SetActive(true);
    }
    public override void ShowGrabHelp()
    {
        base.ShowGrabHelp();
        _htc.SetActive(true);
    }
    public override void ShowMenuHelp()
    {
        base.ShowMenuHelp();
        _handWatch.SetActive(true);
    }
    public override void Hide()
    {
        _htc.SetActive(false);
        _handWatch.SetActive(false);
    }
}
