using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.IconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.IconTextDescription);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.IconTextAction);
            helpInputObject.ShowActionHelp();
        }
    }
}

