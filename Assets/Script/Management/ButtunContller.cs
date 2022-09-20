using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtunContller : MonoBehaviour
{
    /// <summary>Player‚ÌItemList‚ğæ“¾‚·‚é</summary>
    PlayerContller _listGet;
    /// <summary>ItemName(string)‚ğæ“¾‚·‚é‚½‚ß‚Ì•Ï”</summary>
    ItemBase _itemName;
    /// <summary>İ’è‚³‚ê‚½button</summary>
    [SerializeField, Header("Bottan‚ÌPrefab‚ğİ’è‚·‚é")] GameObject[] _bottanPrefab;
    /// <summary>Button‚ÉItem‚ğİ’è‚·‚é</summary>
    ItemBottun _SetItem;
    /// <summary>item‚ÌComponent‚ğæ‚Á‚Ä‚­‚é</summary>
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
