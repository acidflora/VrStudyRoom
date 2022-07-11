using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairPrinterButton : StudyButton
{
    [SerializeField] private InteractableObject _printer;
    [SerializeField] private InteractablePrinter _printerInteractable;

    public override void OnClicked(InteractHand interactHand)
    {
        _printer.StartAction();
    }

    public void EndPrinterAction()
    {
        StãdyButonClicked?.Invoke(1);
    }
}
