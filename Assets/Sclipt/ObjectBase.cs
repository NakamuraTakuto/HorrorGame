using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    public abstract void Activete();

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(this.gameObject.tag == "Object")
        {
            //このgameObjectの上にPlayerを移動させたい
            collision.gameObject.transform.position = this.gameObject.transform.position;
        }
        else if (this.gameObject.tag == "item")
        {
            //このgameObjectがitemならListに入れる
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this);
            //このgameObjectを見えないところに移動する
            this.transform.position = Camera.main.transform.position;
            //このgameObjectのcolliderをoffにする
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
