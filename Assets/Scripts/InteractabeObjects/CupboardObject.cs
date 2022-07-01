using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupboardObject : BaseObject
{
    [SerializeField] private Door _leftDoor;
    [SerializeField] private Door _rightDoor;   
    public override void OnClicked(InteractHand interactHand)
    {
        _leftDoor.OpenDoor();
        _rightDoor.OpenDoor();
        GetComponent<Collider>().enabled = false;
        foreach (var item in outlineObjects)
        {
            item.enabled = false;
        }
    }
}
