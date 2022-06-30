
using System.Collections.Generic;
using System.Linq;
using AosSdk.CommonBehaviours;
using AosSdk.Core.Utils;
using UnityEngine;
using static AosSdk.Core.Utils.AosObjectBase;

public class CollisionController : MonoBehaviour
{
    [SerializeField] private TriggerObject _carpet1;
    [SerializeField] private TriggerObject _carpet2;
    [SerializeField] private ScenarioStepController _scnarioStepController;
    private void OnEnable()
    {
        _carpet1.PlayerEnterTriggerEvent += OnPlayerCarpet1Enter;
        _carpet2.PlayerEnterTriggerEvent += OnPlayerCarpet2Enter;
    }
    private void OnDisable()
    {
        _carpet1.PlayerEnterTriggerEvent -= OnPlayerCarpet1Enter;
        _carpet2.PlayerEnterTriggerEvent -= OnPlayerCarpet2Enter;
    }
    private void OnPlayerCarpet1Enter()
    {
        _scnarioStepController.GetCurrentScenarioStep().StartAction();
    }
    private void OnPlayerCarpet2Enter()
    {
        _scnarioStepController.GetCurrentScenarioStep().StartAction();
    }
}
