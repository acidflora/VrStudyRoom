using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRendererEnabler : MonoBehaviour
{
    [SerializeField] private GameObject _leftHand;
    [SerializeField] private GameObject _rightHand;
    public void EnablaHands(bool value)
    {
        if (value)
        _rightHand.GetComponent<SkinnedMeshRenderer>().enabled = true;
        else
            _leftHand.GetComponent<SkinnedMeshRenderer>().enabled = true;

    }
}
