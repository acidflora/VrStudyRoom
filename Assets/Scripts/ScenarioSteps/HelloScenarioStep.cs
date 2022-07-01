using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloScenarioStep : ScenarioStep
{

    protected override void CheckActions(int number)
    {
      if(number ==0)
        {
            Player.Instance.CanMove = false;
            GamePanelView.Instance.SetHeaderText(textHolder.HelloHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.StartTextDescription);
            teleportController.TeleportToStartPosition();
            StartCoroutine(EndScenarioTimer());
        }
    }
    private IEnumerator EndScenarioTimer()
    {
        yield return new WaitForSeconds(5f);
        EndScenarioStepEvent?.Invoke();
    }
}
