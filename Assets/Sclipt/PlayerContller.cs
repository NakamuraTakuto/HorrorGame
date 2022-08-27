using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Player�̈ړ����x</summary>
    [Header("Player�̈ړ����x"),SerializeField] float _moveSpeed = 5f;
    /// <summary>Player�̃A�C�e�����X�g</summary>
    [Header("Player�̃A�C�e�����X�g"), SerializeField]
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
        //�ړ������̓��͂��擾
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(h, v).normalized;
        _rd.velocity = dir * _moveSpeed;

        //Player�̌����ɍ��킹�ĎqObject�̌����𒲐�����
        if (Mathf.Abs(h) > 0)
        {
            //Player�̌����Ă�������ɍ��킹�ē���
            _rotation.localEulerAngles = new Vector3(0, 0, h * -90);
            
        }
        else if (Mathf.Abs(v) > 0)
        {
            //Player�̌����Ă�������ɓ���
            _rotation.localEulerAngles = new Vector3(0, 0, v > 0 ? 0 : 180);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //Trigger�ɐڐG���Ă���Object��Active�ɂ���
            }
        }
    }


    public void ItemGet(ObjectBase item)
    {
        _itemuList.Add(item);
    }
}
