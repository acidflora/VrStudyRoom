using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputScenarioStep : ScenarioStep
{
    [SerializeField] private Loader _loader;
    [SerializeField] private GameObject _inputScenarioHelper;
    [SerializeField] private GameObject _nextActionButton;
    [SerializeField] private GameObject _playerActionEventSender;
    [SerializeField] private GameObject _watch;

    protected override void CheckActions(int number)
    {
      if(number ==0)
        {
            Player.Instance.CanMove = false;
            _watch.SetActive(false);
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
            Player.Instance.CanMove = true;
            _inputScenarioHelper.SetActive(true);
            if (modeController.IsDesktopMode())
                _inputScenarioHelper.GetComponent<Collider>().enabled = false;
            helpInputObject.ShowInput();
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetHeaderText(textHolder.InputHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.InputTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.InputTextAction);
        }
        else if (number == 3)
        {
            helpInputObject.ShowActionHelp();
            _nextActionButton.SetActive(true);
            GamePanelView.Instance.SetDescriptionText(textHolder.FollowTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.FollowTextAction);
        }
      else if(number ==4)
        {
            GamePanelView.Instance.SetDescriptionText(textHolder.InputTestTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.InputTestTextAction);
            _playerActionEventSender.SetActive(true);

        }
      else if(number ==5)
        {
            _playerActionEventSender.SetActive(false);
            EndScenarioStepEvent?.Invoke();
        }
 
    }


}
