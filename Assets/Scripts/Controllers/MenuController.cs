using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private TeleportController _teleportController;
    private bool _canTeleport = false;
    private bool _menu = false;
public void TeleportToMenu()
    {
        if(_canTeleport)
        {
            if (!_menu)
            {
                _menu = true;
                _teleportController.TeleportToMenuPosition();
            }

            else
            {
                _menu = false;
                _teleportController.TeleportToStartPosition();
            }
             
        }
    }
    public void AllowTeleport(bool value)
    {
        _canTeleport=value;
    }
}
