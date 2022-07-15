using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _actionsScreen;
    protected override void CheckActions(int number)
    {
       
        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.EndHeader);
            GamePanelView.Instance.SetDescriptionText("");
            GamePanelView.Instance.SetActionText("");
            _actionsScreen.SetActive(false);
            helpInputObject.Hide();
        }
  
    }
}
