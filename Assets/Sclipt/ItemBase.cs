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
            //‚±‚ÌgameObject‚ªitem‚È‚çList‚É“ü‚ê‚é
            collision.gameObject.GetComponent<PlayerContller>().ItemGet(this);
            //‚±‚ÌgameObject‚ðŒ©‚¦‚È‚¢‚Æ‚±‚ë‚ÉˆÚ“®‚·‚é
            transform.position = Camera.main.transform.position;
            //‚±‚ÌgameObject‚Ìcollider‚ðoff‚É‚·‚é
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
