using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonPop : ItemBase
{
    /// <summary>��������UI</summary>
    [SerializeField, Header("��������UI��ݒ肷��")] public GameObject _setUI;
    /// <summary>�ŏ���ON�ɂ��邩OFF�ɂ��邩</summary>
    [SerializeField, Header("�A�C�e����Player��List�ɓ�������true")] bool _itemToF = false;
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
