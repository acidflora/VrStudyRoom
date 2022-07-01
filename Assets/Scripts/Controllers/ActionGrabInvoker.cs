using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGrabInvoker : MonoBehaviour
{
    [SerializeField] private ActionObject[] _actionObjects;
    [SerializeField] private ViveStation[] _viveStations;
    private int _actions;
    private int _grabs;
    void Start()
    {
        foreach (var action in _actionObjects)
        {
            action.ActionObjectClickEvent += AllActionObjectsClicked;
        }
        foreach (var grab in _viveStations)
        {
            grab.ViveBoxDeliveredEvent += AllGrabbedObjectsDelivered;
        }
    }
    private void AllActionObjectsClicked(int value)
    {
        _actions += value;
        if(_actions>2)
        {
            ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
            controller.GetCurrentScenarioStep().StartAction();
        }
    }
    private void AllGrabbedObjectsDelivered(int value)
    {
        _grabs += value;
        if (_grabs > 3)
        {
            ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
            controller.GetCurrentScenarioStep().StartAction();
        }

    }

}
