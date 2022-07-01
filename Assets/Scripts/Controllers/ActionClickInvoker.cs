using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionClickInvoker : MonoBehaviour
{
    [SerializeField] private ActionObject[] _actionObjects;
    private int _actions;
    void Start()
    {
        foreach (var action in _actionObjects)
        {
            action.ActionObjectClickEvent += AllActionObjectsClicked;
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

}
