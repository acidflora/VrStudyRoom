using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OtkazButton : BaseButton
{
    public UnityAction ButtonPressetEvent;

    public override void OnClicked(InteractHand interactHand)
    {
        ButtonPressetEvent?.Invoke();
    }
}
