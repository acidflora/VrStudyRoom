using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            GamePanelView.Instance.SetHeaderText(textHolder.WalkingHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MovingText);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.MovingTextDescription1);
            helpInputObject.ShowMovingHelp();
            outlineContainer.OutlineObject("Ñarpet1");
        }
        else if(number == 1)
        {
            canvasPositionChanger.ChangeCanvasPositionToCarpet1();
            outlineContainer.HideAllOutLines();
            GamePanelView.Instance.SetActionText(textHolder.MovingTextDescription2);
              outlineContainer.OutlineObject("Carpet2");
        }
        else if(number ==2)
        {
            canvasPositionChanger.ChangeCanvasPostitionToStart();
            outlineContainer.HideAllOutLines();
        }
    }
}
