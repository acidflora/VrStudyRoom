using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiIconScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _table;
    [SerializeField] private GameObject _printer;
    protected override void CheckActions(int number)
    {

        if(number==0)
        {
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.MultiIconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MultiIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.MultiIconTextAction);
            helpInputObject.ShowActionHelp();
            _table.SetActive(true);
            _printer.SetActive(true);
        }
    }

}
