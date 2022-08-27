using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Playerの移動速度</summary>
    [Header("Playerの移動速度"),SerializeField] float _moveSpeed = 5f;
    /// <summary>Playerのアイテムリスト</summary>
    [Header("Playerのアイテムリスト"), SerializeField]
    List<ObjectBase> _itemuList = new List<ObjectBase>();
    Rigidbody2D _rd;
    Animator _anima;
    Transform _rotation;
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
        _rotation =transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        //移動方向の入力を取得
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;
        _rd.velocity = dir * _moveSpeed;

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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //Triggerに接触しているObjectをActiveにする
            }
        }
    }


    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
