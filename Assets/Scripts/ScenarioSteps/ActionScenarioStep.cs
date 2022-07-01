using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _table;
    [SerializeField] private GameObject _actionObjects;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            canvasPositionChanger.ChangeCanvasPostitionToStart();
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.ActionHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.ActionText);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.ActionTextDescription);
            helpInputObject.ShowActionHelp();
            _table.SetActive(true);
            _actionObjects.SetActive(true);
        }
    }
}
