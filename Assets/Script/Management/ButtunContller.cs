using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtunContller : MonoBehaviour
{
    /// <summary>PlayerのItemListを取得する</summary>
    PlayerContller _listGet;
    /// <summary>ItemName(string)を取得するための変数</summary>
    ItemBase _itemName;
    /// <summary>設定されたbutton</summary>
    [SerializeField, Header("BottanのPrefabを設定する")] GameObject[] _bottanPrefab;
    /// <summary>ButtonにItemを設定する</summary>
    ItemBottun _SetItem;
    /// <summary>itemのComponentを取ってくる</summary>
    GameObject _itemObject;
    List<int> _pop = new List<int>();
    Setter _set;
    void Start()
    {
        _listGet = GameObject.Find("Player").GetComponent<PlayerContller>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (_listGet._itemuList != null)
        //{
        //    for (int i = 0; i < _listGet._itemuList.Count; i++)
        //    {
        //        Instantiate(_bottanPrefab);
        //        _SetItem._item = _listGet._itemuList[i];
        //        _SetItem._itemName = _listGet._itemuList[i].name;
        //    }
        //}
    }

    public void BouttunOnOff()
    {
        for (int i = 0; i < _bottanPrefab.Length; i++)
        {
            _set = _bottanPrefab[0].GetComponent<Setter>();
        }
    }
}
