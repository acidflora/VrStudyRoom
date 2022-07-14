using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapImageButton : BaseButton
{
    [SerializeField] private Sprite[] _sprites;
    private int _curSprite;
    public override void OnClicked(InteractHand interactHand)
    {
        ChangeSprite();
    }
    private void ChangeSprite()
    {
        _curSprite++;
        if (_curSprite > _sprites.Length - 1)
            _curSprite = 0;
        GetComponent<SpriteRenderer>().sprite = _sprites[_curSprite];
    }

}
