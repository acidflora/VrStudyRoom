using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapIconScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _mapButton;
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.IconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MapIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.MapIconTextAction);
            helpInputObject.ShowActionHelp();
            _mapButton.SetActive(true);

        }
        else if(number == 1)
        {
            _mapButton.SetActive(false);
            helpInputObject.Hide();
            EndScenarioStepEvent?.Invoke();
        }
    }
    }
