using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    /// <summary>Player�̈ړ����x</summary>
    [Header("Player�̈ړ����x"), SerializeField] float _moveSpeed = 5f;
    /// <summary>Player�̃A�C�e�����X�g</summary>
    [Header("Player�̃A�C�e�����X�g"), SerializeField] 
    public List<GameObject> _itemuList = new List<GameObject>();
    Rigidbody2D _rd;
    Animator _anima;
    Transform _rotation;
    [Header("Player���ړ��\���ۂ�"), SerializeField]
    public bool _moveToF = true;
    [Header("List�̏�����"), SerializeField]
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
        
        //List�̒��g������������(Inspector����C�Ӂj
        ListReset();
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ������̓��͂��擾
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Player���s���\�Ȏ�
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

        //List�̒��g������������(Inspector����C�Ӂj
        ListReset();
    }

    public void ItemGet(GameObject item)
    {
        _itemuList.Add(item);
    }

    //Player�̌����ɍ��킹��TorrigerObject�̌����𒲐�����
    void TriggerRotation()
    {
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

    //���͂ɂ����Player��Anima���Đ�����
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
        //List�̒��g������������(Inspector����C�Ӂj
        if(_listRe)
        {
            _itemuList = new List<GameObject>();
            _listRe = false;
        }
    }
}
