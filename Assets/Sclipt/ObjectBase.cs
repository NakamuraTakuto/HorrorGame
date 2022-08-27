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
            //‚±‚ÌgameObject‚Ìã‚ÉPlayer‚ğˆÚ“®‚³‚¹‚½‚¢
            collision.gameObject.transform.position = this.gameObject.transform.position;
        }
        else if (this.gameObject.tag == "item")
        {
            //‚±‚ÌgameObject‚ªitem‚È‚çList‚É“ü‚ê‚é
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this);
            //‚±‚ÌgameObject‚ğŒ©‚¦‚È‚¢‚Æ‚±‚ë‚ÉˆÚ“®‚·‚é
            this.transform.position = Camera.main.transform.position;
            //‚±‚ÌgameObject‚Ìcollider‚ğoff‚É‚·‚é
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
