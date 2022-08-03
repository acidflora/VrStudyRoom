using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerActionEventSender : MonoBehaviour
{
    public UnityAction<string> InputEvent;
    [SerializeField] private InputActionProperty _mouseLeftButton;
    [SerializeField] private InputActionProperty _mouseRightButton;
    [SerializeField] private InputActionProperty _wasdButton;
    [SerializeField] private InputActionProperty _middleButton;

    [SerializeField] private InputActionProperty _triggerLButton;
    [SerializeField] private InputActionProperty _sideLButton;
    [SerializeField] private InputActionProperty _circleLButton;

    [SerializeField] private InputActionProperty _triggerRButton;
    [SerializeField] private InputActionProperty _sideRButton;
    [SerializeField] private InputActionProperty _circleRButton;
    private void OnEnable()
    {
        _mouseLeftButton.action.performed += OnActionPressed;
        _triggerLButton.action.performed += OnActionPressed;
        _triggerRButton.action.performed += OnActionPressed;
        _mouseRightButton.action.performed += OnGrabPressed;
       _sideLButton.action.performed += OnGrabPressed;
        _sideRButton.action.performed += OnGrabPressed;
        _wasdButton.action.performed += OnWalkPressed;
        _middleButton.action.performed+=OnWalkPressed;
        _circleLButton.action.performed += OnWalkPressed;
        _circleRButton.action.performed += OnWalkPressed;


    }
    private void OnDisable()
    {
        _mouseLeftButton.action.performed -= OnActionPressed;
        _triggerLButton.action.performed -= OnActionPressed;
        _triggerRButton.action.performed -= OnActionPressed;
        _mouseRightButton.action.performed -= OnGrabPressed;
        _sideLButton.action.performed -= OnGrabPressed;
        _sideRButton.action.performed -= OnGrabPressed;
        _wasdButton.action.performed -= OnWalkPressed;
        _middleButton.action.performed -= OnWalkPressed;
        _circleRButton.action.performed -= OnWalkPressed;
        _circleLButton.action.performed -= OnWalkPressed;
    }


    public void OnActionPressed(InputAction.CallbackContext c)
    {
        InputEvent?.Invoke(TextHelper.ACTION);
    }
    public void OnGrabPressed(InputAction.CallbackContext c)
    {
        InputEvent?.Invoke(TextHelper.GRAB);
    }
    public void OnWalkPressed(InputAction.CallbackContext c)
    {
        InputEvent?.Invoke(TextHelper.WALK);
    }

}
