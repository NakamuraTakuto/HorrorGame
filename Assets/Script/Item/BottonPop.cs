using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPop : ItemBase
{
    /// <summary>Š±Â‚µ‚½‚¢UI</summary>
    [SerializeField, Header("Š±Â‚µ‚½‚¢UI‚ğİ’è‚·‚é")] public GameObject _setUI;
    /// <summary>Å‰‚ÉON‚É‚·‚é‚©OFF‚É‚·‚é‚©</summary>
    [SerializeField, Header("ƒAƒCƒeƒ€‚ªPlayer‚ÌList‚É“ü‚Á‚½‚çtrue")] bool _itemToF = false;
    PlayerContller _playerList;
    Setter _set;

    private void Start()
    {
        _playerList = GameObject.Find("Player").GetComponent<PlayerContller>();
        _set = _setUI.GetComponent<Setter>();
    }

    private void Update()
    {
       if (_playerList._itemuList.Contains(this.gameObject))
        {
            _setUI.SetActive(true);
        }
    }
    // Update is called once per frame
    public void UIon()
    {
        _setUI.SetActive(true);
    }

    public override void ItemActive()
    {
        throw new System.NotImplementedException();
    }
}
