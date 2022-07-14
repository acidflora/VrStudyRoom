using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MapButton : BaseButton
{
    public UnityAction<int> MapButtonClickedEvent;
    [SerializeField] private GameObject _map;
    public override void OnClicked(InteractHand interactHand)
    {
        bool activate = _map.activeSelf ? false : true;
        _map.SetActive(activate);
        MapButtonClickedEvent?.Invoke(1);
    }
}
