using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.PlaceIconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.PlaceIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.PlaceIconTextAction);
            helpInputObject.ShowActionHelp();
        }
        else if (number == 1)
        {

        }
    }
}
