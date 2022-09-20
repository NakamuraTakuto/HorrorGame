using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBottun : MonoBehaviour
{
    /// <summary>ê›íËÇ≥ÇÍÇΩItem</summary>
    [SerializeField, Header("BottunÇ…ê›íËÇµÇΩÇ¢itemñº")] public string _itemName;
    [SerializeField, Header("BottunÇ…ê›íËÇµÇΩÇ¢ItemObject")] public GameObject _item;
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
