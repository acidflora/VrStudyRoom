using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StudyButton : BaseButton
{
    public UnityAction<int> StyduButonClicked;
    public override void OnClicked(InteractHand interactHand)
    {
        StyduButonClicked?.Invoke(1);
        gameObject.SetActive(false);
    }
}
