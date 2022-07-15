using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _studyButtons;
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
            _studyButtons.SetActive(true);
            helpInputObject.ShowActionHelp();
        }
        else if(number == 1)
        {
            _studyButtons.SetActive(false);
            helpInputObject.Hide();
            EndScenarioStepEvent?.Invoke();
        }
    }
}

