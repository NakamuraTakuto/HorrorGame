using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeerHead : MonoBehaviour
{
    public bool _playerSearch = false;
    [SerializeField, Header("EXIT��ݒ肷��")] GameObject _exit = null;
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    [SerializeField, Header("MessagePanel��ݒ肷��")] GameObject _GetMessagePanel;
    [SerializeField, Header("���b�Z�[�W��ݒ肷��")] string _message;
    public bool _redEyeR = false;
    public bool _redEyeL = false;
    Text _setText;

    private void Start()
    {
        _setText = _GetText.GetComponent<Text>();
    }

    private void Update()
    {
        if (_playerSearch)
        {
            if (Input.GetButton("Fire1"))
            {
                _message = "���̗��ڂ��Ȃ�";
                _setText.text = _message;
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            _playerSearch = true;
        }
    }

    public void DeerHeads()
    {
        if (_redEyeL && _redEyeR)
        {
            _exit.SetActive(true);
            _message = "���ŉ�������";
            _setText.text = _message;
        }
        else if (_redEyeL || _redEyeR)
        {
            _message = "�ЖڂɛƂ���";
            _setText.text = _message;
        }
    }
}
