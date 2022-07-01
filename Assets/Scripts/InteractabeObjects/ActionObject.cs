using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject : BaseObject
{
    public override void OnClicked(InteractHand interactHand)
    {
        if (helperPos != null)
            canvasObjectHelper.HidetextHelper();
        Destroy(gameObject);
    }
}
