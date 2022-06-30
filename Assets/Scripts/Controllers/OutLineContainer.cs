using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OutLineContainer : MonoBehaviour
{
    [SerializeField] private OutlineCore[] _outlineObjects;

    public void OutlineObject(string name)
    {
        OutlineCore tempOutline = _outlineObjects.FirstOrDefault(o => o.name == name);
        tempOutline.OutlineWidth = 7;
    }
    public void HideAllOutLines()
    {
        foreach (var outline in _outlineObjects)
        {
            outline.OutlineWidth = 0;
        }
    }

}
