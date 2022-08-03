using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _actionsScreen;
    [SerializeField] private MenuController _menuController;
    protected override void CheckActions(int number)
    {
       
        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            _menuController.AllowTeleport(false);
            GamePanelView.Instance.SetHeaderText(textHolder.EndHeader);
            GamePanelView.Instance.SetDescriptionText("");
            GamePanelView.Instance.SetActionText("");
            _actionsScreen.SetActive(false);
            helpInputObject.Hide();
        }
  
    }
}
