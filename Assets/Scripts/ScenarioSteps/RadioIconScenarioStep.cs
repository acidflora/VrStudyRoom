using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioIconScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _radioButton;
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.IconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.RadioIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.RadioIconTextAction);
            helpInputObject.ShowActionHelp();
            _radioButton.SetActive(true);

        }
        else if (number == 1)
        {
            _radioButton.SetActive(false);
            helpInputObject.Hide();
            EndScenarioStepEvent?.Invoke();
        }
    }
}