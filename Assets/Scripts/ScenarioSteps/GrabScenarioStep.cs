using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScenarioStep : ScenarioStep
{
    [SerializeField] private ViveStation[] _viveStations;
    [SerializeField] private GameObject _cupboard;

    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            canvasPositionChanger.ChangeCanvasPostitionToStart();
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.GrabHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.GrabTextDescription);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.GrabTextAction);
            helpInputObject.ShowGrabHelp();
            _cupboard.GetComponent<Collider>().enabled = true;
            foreach (var viveStation in _viveStations)
            {
                viveStation.DisableViveBoxForGrabAction();
            }
        }
        else if(number==1)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }
}