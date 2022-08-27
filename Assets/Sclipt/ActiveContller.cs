using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveContller : MonoBehaviour
{
    /// <summary>Playerのアイテムリスト</summary>
    [Header("Playerのアイテムリスト"), SerializeField]
    List<ObjectBase> _itemuList = new List<ObjectBase>();

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Debug.Log("当たった");
        }
    }*/

    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
