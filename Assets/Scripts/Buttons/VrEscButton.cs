using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrEscButton :BaseButton
{

    [SerializeField] private MenuController _menuController;

    public override void OnClicked(InteractHand interactHand)
    {
        _menuController.TeleportToMenu();
    }
}
