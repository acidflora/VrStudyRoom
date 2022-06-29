using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeController : MonoBehaviour
{
    [SerializeField] private GameObject _desktopPlayer;
    [SerializeField] private GameObject _vrPlayer;
    public bool IsDesktopMode()
    {
        if (!_desktopPlayer.activeSelf)
        {
            return false;
        }
        else return true;
    }
}
