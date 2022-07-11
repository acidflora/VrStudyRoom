using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StudyButton : BaseButton
{
    public UnityAction<int> StãdyButonClicked;
    public override void OnClicked(InteractHand interactHand)
    {
        StãdyButonClicked?.Invoke(1);
        gameObject.SetActive(false);
    }
}
