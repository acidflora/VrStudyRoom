using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    public UnityAction EndScenarioStepEvent;
    [SerializeField] protected SoundPlayer vrSoundPlayer;
    [SerializeField] protected SoundPlayer desktopSoundPlayer;

    protected GameCanvasPositionChanger canvasPositionChanger;
    protected OutLineContainer outlineContainer;
    protected SoundPlayer currentSoundPlayer;
    protected ModeController modeController;
    protected TextHolder textHolder;
    protected HelpInputObject helpInputObject;
    protected TeleportController teleportController;
    public void Start()
    {
        modeController = FindObjectOfType<ModeController>();
        outlineContainer = FindObjectOfType<OutLineContainer>();
        canvasPositionChanger = FindObjectOfType<GameCanvasPositionChanger>();
        teleportController = FindObjectOfType<TeleportController>();
        if (modeController.IsDesktopMode())
        {
            textHolder = new TextHolderDesktop();
            currentSoundPlayer = desktopSoundPlayer;
            helpInputObject = FindObjectOfType<DeskHelpInputObject>();
        }
        else
        {
            textHolder = new TextHolderVr();
            currentSoundPlayer = vrSoundPlayer;
#if TRUE
            helpInputObject = FindObjectOfType<OculusHelpInputObject>();
#else
            helpInputObject = FindObjectOfType<VRHelpInputObject>();
#endif
        }

        textHolder.SetText();
    }

    protected int action;
    public void StartScenarioStep()
    {
        StartAction();
    }
    public void StartAction()
    {
        CheckActions(action);
        action++;
    }
    protected virtual void CheckActions(int number)
    {
    }
    public HelpInputObject GetCurrentHelpInput()
    {
        return helpInputObject;
    }
}
