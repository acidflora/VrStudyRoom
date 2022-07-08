using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairPrinterButton : BaseButton
{
    [SerializeField] private InteractableObject _printer;

    public override void OnClicked(InteractHand interactHand)
    {
        _printer.StartAction();
    }
}
