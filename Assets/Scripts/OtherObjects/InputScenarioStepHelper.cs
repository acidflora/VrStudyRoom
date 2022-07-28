using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputScenarioStepHelper : BaseObject
{
    [SerializeField] private InputActionProperty _mouseLeftButton;
    [SerializeField] private InputActionProperty _mouseRightButton;
    [SerializeField] private InputActionProperty _mouseMiddleButton;
    [SerializeField] private InputActionProperty _wsadButton;
 
    [SerializeField] private ScenarioStepController _scenarioStepController;
    public override void OnHoverIn(InteractHand interactHand)
    {
        HelpScenario();
    }
    private void OnEnable()
    {
        _mouseLeftButton.action.performed += OnInputPerformed;
        _mouseRightButton.action.performed += OnInputPerformed;
        _mouseMiddleButton.action.performed+=OnInputPerformed;
        _wsadButton.action.performed += OnInputPerformed;
    }
    private void OnDisable()
    {
        _mouseLeftButton.action.performed -= OnInputPerformed;
        _mouseRightButton.action.performed -= OnInputPerformed;
        _mouseMiddleButton.action.performed -= OnInputPerformed;
        _wsadButton.action.performed -= OnInputPerformed;
    }
    private void OnInputPerformed(InputAction.CallbackContext c)
    {
        HelpScenario();
    }
    private void HelpScenario()
    {
        _scenarioStepController.GetCurrentScenarioStep().StartAction();
        Destroy(gameObject);
    }
}
