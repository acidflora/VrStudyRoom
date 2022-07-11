using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGrabInvoker : MonoBehaviour
{
    [SerializeField] private ActionObject[] _actionObjects;
    [SerializeField] private ViveStation[] _viveStations;
    [SerializeField] private StudyButton[] _studyButtons;
    [SerializeField] private StudyButton[] _studyPrinterButtons;
    private int _actions;
    private int _grabs;
    void Start()
    {
        foreach (var action in _actionObjects)
        {
            action.ActionObjectClickEvent += OnAllActionObjectsClicked;
        }
        foreach (var grab in _viveStations)
        {
            grab.ViveBoxDeliveredEvent += OnAllGrabbedObjectsDelivered;
        }
        foreach (var studyButton in _studyButtons)
        {
            studyButton.StãdyButonClicked += OnAllActionObjectsClicked;
        }
        foreach (var studyButton in _studyPrinterButtons)
        {
            studyButton.StãdyButonClicked += OnAllActionObjectsClicked;
        }
    }
    private void OnAllActionObjectsClicked(int value)
    {
        _actions += value;
        if (_actions>2)
        {
            ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
            controller.GetCurrentScenarioStep().StartAction();
            _actions = 0;
        }
    }
    private void OnAllGrabbedObjectsDelivered(int value)
    {
        _grabs += value;
        if (_grabs > 3)
        {
            ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
            controller.GetCurrentScenarioStep().StartAction();
        }
    }

}
