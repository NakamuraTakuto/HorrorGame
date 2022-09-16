using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBottun : MonoBehaviour
{
    /// <summary>設定されたItem</summary>
    [SerializeField, Header("Bottunに設定したいitem名")] public string _itemName;
    [SerializeField, Header("Bottunに設定したいItemObject")] public GameObject _item;
    Text _text;
 
    private void Update()
    {
        _text.text = _itemName;
    }
}
