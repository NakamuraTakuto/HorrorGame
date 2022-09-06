using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    public abstract void ItemActive();

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.tag == "Item" && Input.GetButtonDown("Fire1"))
        {
            //このgameObjectがitemならListに入れる
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this);
            //このgameObjectを見えないところに移動する
            transform.position = Camera.main.transform.position;
            //このgameObjectのcolliderをoffにする
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
