using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Playerの移動速度</summary>
    [Header("Playerの移動速度"), SerializeField] float _moveSpeed = 5f;
    /// <summary>Playerのアイテムリスト</summary>
    [Header("Playerのアイテムリスト"), SerializeField] 
    public List<GameObject> _itemuList = new List<GameObject>();
    Rigidbody2D _rd;
    Animator _anima;
    Transform _rotation;
    [Header("Playerが移動可能か否か"), SerializeField]
    public bool _moveToF = true;
    [Header("Listの初期化"), SerializeField]
    bool _listRe = false;
    float h;
    float v;
    SpriteRenderer _sprite;
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _rotation = transform.GetChild(0);
        _moveToF = true;
        _anima = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
        
        //Listの中身を初期化する(Inspectorから任意）
        ListReset();
    }

    // Update is called once per frame
    void Update()
    {
        //移動方向の入力を取得
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Playerが行動可能な時
        if (_moveToF)
        {
            Vector2 dir = new Vector2(h, v).normalized;
            _rd.velocity = dir * _moveSpeed;
            TriggerRotation();
            AnimaPlayer();
        }
        else if (_moveToF == false)
        {
            Vector2 dir = new Vector2(h,v).normalized * 0;
            _rd.velocity = _moveSpeed * dir * 0;
            TriggerRotation();
            //AnimaPlayer();
        }

        //Listの中身を初期化する(Inspectorから任意）
        ListReset();
    }

    public void ItemGet(GameObject item)
    {
        _itemuList.Add(item);
    }

    //Playerの向きに合わせてTorrigerObjectの向きを調整する
    void TriggerRotation()
    {
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
    }

    //入力によってPlayerのAnimaを再生する
    void AnimaPlayer()
    {
        if (h > 0)
        {
            _sprite.flipX = true;
        }
        else if (h < 0)
        {
            _sprite.flipX = false;
        }

        if (Input.GetButton("Horizontal"))
        {
            _anima.SetBool("Side",true);
        }
       else if (Input.GetButton("Vertical"))
        {
            _anima.SetBool("Side", false);
        }
       
        if (v < 0)
        {
            _anima.SetBool("Down", true);
        }
       else if (v > 0)
        {
            _anima.SetBool("Up", true);
        }
        else
        {
            _anima.SetBool("Up", false);
            _anima.SetBool("Down", false);
        }
    }
    private void ListReset()
    {
        //Listの中身を初期化する(Inspectorから任意）
        if(_listRe)
        {
            _itemuList = new List<GameObject>();
            _listRe = false;
        }
    }
}
