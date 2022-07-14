using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.MenuHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MenuTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.MenuTextAction);
            helpInputObject.ShowMenuHelp();
        }
        else if (number == 1)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }
}
