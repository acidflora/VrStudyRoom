using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class EscButton : MonoBehaviour
{
    [SerializeField] private InputActionProperty _menuAction;
    [SerializeField] private MenuController _menuController;
    private void OnEnable()
    {
        _menuAction.action.performed += OnShowMenu;
    }
    private void OnDisable()
    {
        _menuAction.action.performed -= OnShowMenu;
    }
    private void OnShowMenu(InputAction.CallbackContext c)
    {
        _menuController.TeleportToMenu();
    }
}
