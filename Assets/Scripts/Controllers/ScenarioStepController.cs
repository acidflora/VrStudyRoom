using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioStepController : MonoBehaviour
{
    [SerializeField] private ScenarioStep[] _scenarioSteps;

    private int _currentScenarioStep;
    private void Awake()
    {
        foreach (var scenarioStep in _scenarioSteps)
        {
            scenarioStep.EndScenarioStepEvent += OnStartNextScenarioStep;
        }
    }
    private void Start()
    {
        _scenarioSteps[_currentScenarioStep].StartScenarioStep();
    }
    private void OnStartNextScenarioStep()
    {
        _currentScenarioStep++;
        _scenarioSteps[_currentScenarioStep].StartScenarioStep();
    }

    public ScenarioStep GetCurrentScenarioStep()
    {
        return _scenarioSteps[_currentScenarioStep];
    }
}
