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
    public void Start()
    {
        modeController = FindObjectOfType<ModeController>();
        outlineContainer = FindObjectOfType<OutLineContainer>();
        canvasPositionChanger = FindObjectOfType<GameCanvasPositionChanger>();
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
            helpInputObject = FindObjectOfType<VRHelpInputObject>();
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
}
