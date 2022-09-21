using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectBase : MonoBehaviour
{
    /// <summary>Player�̈ʒu���擾����ׂ̕ϐ�</summary>
    Vector3 _position;
    [Header("�v���C���[�̈ړ�����w�肷��object������"),SerializeField]
    GameObject _playUpObj;
    [Header("Player�Ƃ��Ďg�p���Ă���object�̐ݒ�"), SerializeField]
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

    //Player��collider���ڐG���Ă��違���v���C���[�����N���b�N�������ɍs����������
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Fire1") && collision.gameObject.tag == "Player")
        {
            //Player�̈ړ��O�ɂ���position���o���Ă���
            _position = collision.gameObject.transform.position;
            //����gameObject�̏��Player���ړ�������
            collision.gameObject.transform.position = _playUpObj.transform.position;
            //Player���ړ��s�ɂ���
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
