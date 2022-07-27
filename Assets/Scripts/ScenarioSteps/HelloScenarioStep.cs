using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloScenarioStep : ScenarioStep
{
    [SerializeField] private Loader _loader;

    protected override void CheckActions(int number)
    {
      if(number ==0)
        {
            Player.Instance.CanMove = false;
            GamePanelView.Instance.SetHeaderText(textHolder.HelloHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.HelloDescription);
            teleportController.TeleportToStartPosition();
            _loader.StartLoading(1);
        }
      else if(number==1)
        {
            GamePanelView.Instance.SetDescriptionText(textHolder.HelloDescription2);
            _loader.StartLoading(2);
        }
        else if (number == 2)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }


}
