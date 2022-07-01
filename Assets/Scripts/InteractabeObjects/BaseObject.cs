using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
using AosSdk.ThirdParty.QuickOutline.Scripts;

public class BaseObject : MonoBehaviour, IClickAble, IHoverAble
{


    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;



    [SerializeField] protected OutlineCore[] outlineObjects;
    [SerializeField] protected Transform helperPos;
    [SerializeField] protected string helperName;

    protected CanvasObjectHelper canvasObjectHelper;

    protected virtual void Start()
    {
        canvasObjectHelper = FindObjectOfType<CanvasObjectHelper>();
    }

    public virtual void OnClicked(InteractHand interactHand)
    {

    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (helperPos != null)
            canvasObjectHelper.ShowTextHelper(helperName, helperPos);
        if (outlineObjects != null)
            foreach (var obj in outlineObjects)
            {
                obj.OutlineWidth = 3;
            }
    }

    public virtual void OnHoverOut(InteractHand interactHand)
    {
        if (helperPos != null)
            canvasObjectHelper.HidetextHelper();
        if (outlineObjects != null)
            foreach (var obj in outlineObjects)
            {
                obj.OutlineWidth = 0;
            }
    }
}



