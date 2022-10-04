using UnityEngine;

public class OculusHelpInputObject : HelpInputObject
{
    [SerializeField] private GameObject _oculus;
    [SerializeField] private GameObject _handWatch;
    [SerializeField] private ColorChanger _triggerButton;
    [SerializeField] private ColorChanger _gripButton;
    [SerializeField] private ColorChanger _joystick;
    [SerializeField] private ColorChanger _watch;

    public override void ShowMovingHelp()
    {
        _oculus.SetActive(true);
        HideAllBlinks();
        _joystick.ControlBlink(true);
    }
    public override void ShowActionHelp()
    {
        _oculus.SetActive(true);
        HideAllBlinks();
        _triggerButton.ControlBlink(true);
    }
    public override void ShowGrabHelp()
    {
        _oculus.SetActive(true);
        HideAllBlinks();
        _gripButton.ControlBlink(true);
    }
    public override void ShowMenuHelp()
    {
        _oculus.SetActive(true);
        _handWatch.SetActive(true);
        HideAllBlinks();
        _triggerButton.ControlBlink(true);
        _watch.ControlBlink(true);

    }
    public override void Hide()
    {
        HideAllBlinks();
        _oculus.SetActive(false);
        _handWatch.SetActive(false);
    }
    public override void ShowInput()
    {
        HideAllBlinks();
        _oculus.SetActive(true);
    }
    public override void HideAllBlinks()
    {
        _triggerButton.ControlBlink(false);
        _joystick.ControlBlink(false);
        _gripButton.ControlBlink(false);
        _watch.ControlBlink(false);
    }

}
