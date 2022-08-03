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
            teleportController.TeleportToActionPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.ActionHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.ActionTextDescription);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.ActionTextAction);
            helpInputObject.ShowActionHelp();
            _table.SetActive(true);
            _actionObjects.SetActive(true);
        }
        else if(number ==1)
        {
            _table.SetActive(false);
            EndScenarioStepEvent?.Invoke();
        }
    }
}
