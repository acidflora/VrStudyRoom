using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _keyboard;
    [SerializeField] private GameObject _mouse;
    [SerializeField] private GameObject _htc;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            GamePanelView.Instance.SetHeaderText("Передвижение");
            GamePanelView.Instance.SetDescriptionText(textHolder.MovingText);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.MovingTextDescription);
            if (modeController.IsDesktopMode())
            {
                _keyboard.SetActive(true);
                _mouse.SetActive(true);
            }
            else
                _htc.SetActive(true);
        }
    }
}
