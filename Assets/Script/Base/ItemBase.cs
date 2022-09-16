using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [Header("アイテムの名前を設定する"), SerializeField] string _itemName = default;
    public abstract void ItemActive();

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            //このgameObjectがitemならListに入れる
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this.gameObject);
            //このgameObjectを見えないところに移動する
            transform.position = Camera.main.transform.position;
            //このgameObjectのcolliderをoffにする
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
