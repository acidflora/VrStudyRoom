using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempBackButton : BaseButton
{
    public override void OnClicked(InteractHand interactHand)
    {
        ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
        controller.GetCurrentScenarioStep().StartAction();
    }
}
