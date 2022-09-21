using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    /// <summary>Playerの位置を取得する為の変数</summary>
    Vector3 _position;
    [Header("プレイヤーの移動先を指定するobjectをつける"),SerializeField]
    GameObject _playUpObj;
    [Header("Playerとして使用しているobjectの設定"), SerializeField]
    string _playerObject;
    /// <summary>PlayerContller(Component)</summary>
    PlayerContller _playerC;
    GameObject _playerObjPosition;
    public abstract void ObjActivete();

    private void Start()
    {
        _playerC = GameObject.Find(_playerObject).GetComponent<PlayerContller>();
        _playerObjPosition = GameObject.Find(_playerObject);
    }

    private void Update()
    {
        if (_playerC._moveToF == false)
        {
            if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
            {
                _playerObjPosition.transform.position = _position;
                _playerC._moveToF = true;
            }
        }
    }

    //Playerのcolliderが接触している＆＆プレイヤーが左クリックした時に行いたい処理
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1") && collision.gameObject.tag == "Player")
        {
            //Playerの移動前にいたpositionを覚えておく
            _position = collision.gameObject.transform.position;
            //このgameObjectの上にPlayerを移動させる
            collision.gameObject.transform.position = _playUpObj.transform.position;
            //Playerを移動不可にする
            _playerC._moveToF = false;
        }
        else if (_playerC._moveToF == false)
        {
            if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
            {
                _playerObjPosition.transform.position = _position;
                _playerC._moveToF = true;
            }
        }
    }
}
