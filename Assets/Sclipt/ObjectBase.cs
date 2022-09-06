using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    /// <summary>Playerの位置を取得する為の変数</summary>
    Vector3 _position;
    public abstract void Activete();

    //colliderが接触している＆＆プレイヤーが左クリックした時に行いたい処理
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1") && collision.gameObject.tag == "Player")
        {
            if (gameObject.tag == "Object" && Input.GetButtonDown("Fire2"))
            {
                //このgameObjectの上にPlayerを移動させたい
                _position = collision.gameObject.transform.parent.position;
                //collision.gameObject.transform.parent.position = _position;
                collision.gameObject.transform.position = gameObject.transform.parent.position + Vector3.up;
            }
        }
    }
}
