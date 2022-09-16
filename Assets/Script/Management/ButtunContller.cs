using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtunContller : MonoBehaviour
{
    /// <summary>Player��ItemList���擾����</summary>
    PlayerContller _listGet;
    /// <summary>ItemName(string)���擾���邽�߂̕ϐ�</summary>
    ItemBase _itemName;
    /// <summary>�ݒ肳�ꂽbutton</summary>
    [SerializeField, Header("Bottan��Prefab��ݒ肷��")] GameObject _bottanPrefab;
    /// <summary>Button��Item��ݒ肷��</summary>
    ItemBottun _SetItem;
    /// <summary>item��Component������Ă���</summary>
    GameObject _itemObject;
    // Start is called before the first frame update
    void Start()
    {
        _listGet = GameObject.Find("Player").GetComponent<PlayerContller>();
        _SetItem = _bottanPrefab.GetComponent<ItemBottun>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_listGet._itemuList != null)
        {
            for (int i = 0; i < _listGet._itemuList.Count; i++)
            {
                Instantiate(_bottanPrefab);
                _SetItem._item = _listGet._itemuList[i];
                _SetItem._itemName = _listGet._itemuList[i].name;
            }
        }
    }
}
