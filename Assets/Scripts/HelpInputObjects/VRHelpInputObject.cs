using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _htc;
    [SerializeField] private GameObject _handWatch;
    public override void ShowMovingHelp()
    {
      
        _htc.SetActive(true);
    }
    public override void ShowActionHelp()
    {
     
        _htc.SetActive(true);
    }
    public override void ShowGrabHelp()
    {
      
        _htc.SetActive(true);
    }
    public override void ShowMenuHelp()
    {
       
        _handWatch.SetActive(true);
    }
    public override void Hide()
    {
        _htc.SetActive(false);
        _handWatch.SetActive(false);
    }
    public override void ShowInput()
    {
         HideAllBlinks();
        _htc.SetActive(true);
    }

}
