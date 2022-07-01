using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionObject : BaseObject
{
    public UnityAction <int> ActionObjectClickEvent;
    public override void OnClicked(InteractHand interactHand)
    {
        if (helperPos != null)
            canvasObjectHelper.HidetextHelper();
        ActionObjectClickEvent?.Invoke(1);
        Destroy(gameObject);
    }
}
