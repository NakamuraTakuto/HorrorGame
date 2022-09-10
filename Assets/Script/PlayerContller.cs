using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Playerの移動速度</summary>
    [Header("Playerの移動速度"), SerializeField] float _moveSpeed = 5f;
    /// <summary>Playerのアイテムリスト</summary>
    [Header("Playerのアイテムリスト"), SerializeField] 
    public List<ItemBase> _itemuList = new List<ItemBase>();
    Rigidbody2D _rd;
    Animator _anima;
    Transform _rotation;
    [Header("Playerが移動可能か否か"), SerializeField]
    public bool _moveToF = true;
    [Header("Listの初期化"), SerializeField]
    bool _listRe = false;
    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _rotation = transform.GetChild(0);
        _moveToF = true;
        if(_moveToF)
        {
            Debug.Log("true");
        }

        //Listの中身を初期化する(Inspectorから任意）
        ListReset();
    }

    // Update is called once per frame
    void Update()
    {
        //Playerが行動可能な時
        if (_moveToF)
        {
            //移動方向の入力を取得
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
            Vector2 dir = new Vector2(h, v).normalized;
            _rd.velocity = dir * _moveSpeed;
        }
        else if (_moveToF == false)
        {
            Vector2 dir = new Vector2(h,v).normalized * 0;
            _rd.velocity = _moveSpeed * dir * 0;
        }

        //Playerの向きに合わせて子Objectの向きを調整する
        if (Mathf.Abs(h) > 0)
        {
            //Playerの向いている方向に合わせて動く
            _rotation.localEulerAngles = new Vector3(0, 0, h * -90);
        }
        else if (Mathf.Abs(v) > 0)
        {
            //Playerの向いている方向に動く
            _rotation.localEulerAngles = new Vector3(0, 0, v > 0 ? 0 : 180);
        }

        //Listの中身を初期化する(Inspectorから任意）
        ListReset();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(_itemuList);
        }
    }

    public void ItemGet(ItemBase item)
    {
        _itemuList.Add(item);
    }

    private void ListReset()
    {
        //Listの中身を初期化する(Inspectorから任意）
        if(_listRe)
        {
            _itemuList = new List<ItemBase>();
            _listRe = false;
        }
    }
}
