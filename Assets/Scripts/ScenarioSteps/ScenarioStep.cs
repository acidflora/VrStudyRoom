using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ScenarioStep : MonoBehaviour
{
    public UnityAction EndScenarioStepEvent;
    [SerializeField] protected SoundPlayer vrSoundPlayer;
    [SerializeField] protected SoundPlayer desktopSoundPlayer;

    protected SoundPlayer currentSoundPlayer;
    protected ModeController modeController;
    protected TextHolder textHolder;
    public void Start()
    {
        modeController = FindObjectOfType<ModeController>();
        if (modeController.IsDesktopMode())
        {
            textHolder = new TextHolderDesktop();
            currentSoundPlayer = desktopSoundPlayer;
        }
        else
        {
            textHolder = new TextHolderVr();
            currentSoundPlayer = vrSoundPlayer;
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
