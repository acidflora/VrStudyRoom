using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButtons : BaseObject
{
    [SerializeField] private GameObject _buttons;
    public override void OnClicked(InteractHand interactHand)
    {
        GetComponent<Collider>().enabled = false;
        _buttons.SetActive(true);
    }
}
