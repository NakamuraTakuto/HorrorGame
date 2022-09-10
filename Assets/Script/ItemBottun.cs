using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBottun : MonoBehaviour
{
    /// <summary>Playerのアイテムリストを取ってくるための変数</summary>
    PlayerContller _playerGetItem;
    void Start()
    {
        _playerGetItem = GameObject.Find("Player").GetComponent<PlayerContller>();
    }
    
    void Update()
    {
        if (_playerGetItem._itemuList != null)
        {
            var ItemStr = _playerGetItem._itemuList;

            foreach (var l in ItemStr)
            {

            }
        }
    }
}
