using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBottun : MonoBehaviour
{
    /// <summary>Player�̃A�C�e�����X�g������Ă��邽�߂̕ϐ�</summary>
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
