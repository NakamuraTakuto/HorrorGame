using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Playerの移動速度</summary>
    [Header("Playerの移動速度"),SerializeField] float _moveSpeed = 5f;
    Rigidbody2D _rd;
    Animator _anima;
    /// <summary>Playerのアイテムリスト</summary>
    [Header("Playerのアイテムリスト"), SerializeField]
    List<ObjectBase> _itemuList = new List<ObjectBase>();
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //移動方向の入力を取得
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;
        _rd.velocity = dir * _moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Debug.Log("当たった");
        }
    }

    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
