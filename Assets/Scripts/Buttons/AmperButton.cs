using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmperButton : BaseButton
{
    [SerializeField] private GameObject _amper;
    [SerializeField] private GameObject _measureButtons;
    [SerializeField] private ShupController _shupController;

    private bool _clicked = false;
    public override void OnClicked(InteractHand interactHand)
    {
        ClickAmperButton();
    }
    private void ClickAmperButton()
    {
        if(!_clicked)
        {
            _amper.SetActive(true);
            _measureButtons.SetActive(true);
            _clicked = true;
        }
        else
        {
            _amper.SetActive(false);
            _measureButtons.SetActive(false);
            _shupController.ResetShupPosition();
            _clicked = false;
        }

    }
}
