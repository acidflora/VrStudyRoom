using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ViveStation : MonoBehaviour
{
    public UnityAction<int> ViveBoxDeliveredEvent;
    [SerializeField] private OutlineCore _outlineCore;
    [SerializeField] private GameObject _viveBox;

    public void DisableViveBoxForGrabAction()
    {
        if (_outlineCore != null)
            _outlineCore.OutlineWidth = 3;
        if (_viveBox != null)
            _viveBox.SetActive(false);
    }
    public void EnableViveBox()
    {
        if (_outlineCore != null)
            _outlineCore.OutlineWidth = 0;
        if (_viveBox != null)
            _viveBox.SetActive(true);
        ViveBoxDeliveredEvent?.Invoke(1);
        GetComponent<Collider>().enabled = false;
    }

}
