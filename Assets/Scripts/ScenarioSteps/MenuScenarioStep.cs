using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScenarioStep : ScenarioStep
{
    [SerializeField] private MenuController _menuController;
    [SerializeField] private GameObject _vrWatch;
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.MenuHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MenuTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.MenuTextAction);
            helpInputObject.ShowMenuHelp();
            _menuController.AllowTeleport(true);
            _vrWatch.SetActive(true);
        }
        else if (number == 1)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }
}
