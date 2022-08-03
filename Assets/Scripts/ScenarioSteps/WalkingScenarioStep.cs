using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            Player.Instance.CanMove = true;
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.WalkingHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MovingTextDescription);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.MovingTextAction1);
            helpInputObject.ShowMovingHelp();
            outlineContainer.OutlineObject("Ñarpet1");
        }
        else if(number == 1)
        {
            canvasPositionChanger.ChangeCanvasPositionToCarpet1();
            outlineContainer.HideAllOutLines();
            GamePanelView.Instance.SetDescriptionText("");
            GamePanelView.Instance.SetActionText(textHolder.MovingTextAction2);
              outlineContainer.OutlineObject("Carpet2");
        }
        else if(number ==2)
        {
            outlineContainer.HideAllOutLines();
            helpInputObject.Hide();
            EndScenarioStepEvent?.Invoke();
        }
    }
}
