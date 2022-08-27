using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Player�̈ړ����x</summary>
    [Header("Player�̈ړ����x"),SerializeField] float _moveSpeed = 5f;
    Rigidbody2D _rd;
    Animator _anima;
    /// <summary>Player�̃A�C�e�����X�g</summary>
    [Header("Player�̃A�C�e�����X�g"), SerializeField]
    List<ObjectBase> _itemuList = new List<ObjectBase>();
    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ������̓��͂��擾
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;
        _rd.velocity = dir * _moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Debug.Log("��������");
        }
    }

    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
