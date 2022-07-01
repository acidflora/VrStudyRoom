using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    [SerializeField] private GameObject _descPlayer;
    [SerializeField] private GameObject _vrPlayer;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private CameraFlash _cameraFlash;

    public void TeleportToStartPosition()
    {
        _cameraFlash.CameraFlashStart();
        _descPlayer.transform.position = new Vector3(_startPosition.transform.position.x, _descPlayer.transform.position.y, _startPosition.transform.position.z);
        _vrPlayer.transform.position = new Vector3(_startPosition.transform.position.x, _vrPlayer.transform.position.y, _startPosition.transform.position.z);
        _descPlayer.transform.rotation = _startPosition.rotation;
        _vrPlayer.transform.rotation = _startPosition.rotation;
    }
}
