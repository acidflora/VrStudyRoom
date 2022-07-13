using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _placeTable;
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.PlaceIconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.PlaceIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.PlaceIconTextAction);
            helpInputObject.ShowActionHelp();
            _placeTable.SetActive(true);
        }
        else if (number == 1)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }
}
