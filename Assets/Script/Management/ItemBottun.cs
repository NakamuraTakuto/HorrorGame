using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBottun : MonoBehaviour
{
    /// <summary>�ݒ肳�ꂽItem</summary>
    [SerializeField, Header("Bottun�ɐݒ肵����item��")] public string _itemName;
    [SerializeField, Header("Bottun�ɐݒ肵����ItemObject")] public GameObject _item;
    Text _text;
 
    private void Update()
    {
        if (_itemName != null)
        {
            _text.text = _itemName;
        }
        else if (_itemName == null)
        {
            Debug.Log("null");
        }
    }
}
