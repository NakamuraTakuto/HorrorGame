using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveContller : MonoBehaviour
{
    /// <summary>Player�̃A�C�e�����X�g</summary>
    [Header("Player�̃A�C�e�����X�g"), SerializeField]
    List<ObjectBase> _itemuList = new List<ObjectBase>();

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Debug.Log("��������");
        }
    }*/

    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
