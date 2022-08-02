using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : BaseButton
{
    public override void OnClicked(InteractHand interactHand)
    {
        ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
        controller.GetCurrentScenarioStep().StartAction();
        gameObject.SetActive(false);
    }
}
