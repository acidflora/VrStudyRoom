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
        Player.Instance.TeleportTo(_startPosition);
        _descPlayer.transform.rotation = _startPosition.rotation;
        _vrPlayer.transform.rotation = _startPosition.rotation;
    }
}
