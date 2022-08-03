using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    [SerializeField] private GameObject _descPlayer;
    [SerializeField] private GameObject _vrPlayer;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _menuPosition;
    [SerializeField] private Transform _actionPosition;
    [SerializeField] private CameraFlash _cameraFlash;

    public void TeleportToStartPosition()
    {
        _cameraFlash.CameraFlashStart();
        _descPlayer.transform.position = new Vector3(_startPosition.transform.position.x, _descPlayer.transform.position.y, _startPosition.transform.position.z);
        _vrPlayer.transform.position = new Vector3(_startPosition.transform.position.x, _vrPlayer.transform.position.y, _startPosition.transform.position.z);
        _descPlayer.transform.rotation = _startPosition.rotation;
        _vrPlayer.transform.rotation = _startPosition.rotation;
    }
    public void TeleportToMenuPosition()
    {
        _cameraFlash.CameraFlashStart();
        _descPlayer.transform.position = new Vector3(_menuPosition.transform.position.x, _descPlayer.transform.position.y, _menuPosition.transform.position.z);
        _vrPlayer.transform.position = new Vector3(_menuPosition.transform.position.x, _vrPlayer.transform.position.y, _menuPosition.transform.position.z);
        _descPlayer.transform.rotation = _menuPosition.rotation;
        _vrPlayer.transform.rotation = _menuPosition.rotation;
    }
    public void TeleportToActionPosition()
    {
        _cameraFlash.CameraFlashStart();
        _descPlayer.transform.position = new Vector3(_actionPosition.transform.position.x, _descPlayer.transform.position.y, _actionPosition.transform.position.z);
        _vrPlayer.transform.position = new Vector3(_actionPosition.transform.position.x, _vrPlayer.transform.position.y, _actionPosition.transform.position.z);
        _descPlayer.transform.rotation = _actionPosition.rotation;
        _vrPlayer.transform.rotation = _actionPosition.rotation;

    }
}
