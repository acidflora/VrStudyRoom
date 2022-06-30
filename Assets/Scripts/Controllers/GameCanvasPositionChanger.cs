using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvasPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _carpet1Position;

    public void ChangeCanvasPostitionToStart()
    {
        transform.position = _startPosition.position;
        transform.rotation = _startPosition.rotation;
    }
    public void ChangeCanvasPositionToCarpet1()
    {
        transform.position = _carpet1Position.position;
        transform.rotation = _carpet1Position.rotation;
    }
}
