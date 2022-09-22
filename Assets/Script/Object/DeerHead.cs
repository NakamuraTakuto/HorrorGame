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
    [SerializeField] bool _tofMessage = true;
    Text _setText;

    private void Start()
    {
        _setText = _GetText.GetComponent<Text>();
    }

    private void Update()
    {
        if (_playerSearch)
        {
            if (Input.GetButton("Fire1") && _tofMessage && !_redEyeL && !_redEyeR)
            {
                _message = "���̗��ڂ��Ȃ�";
                _setText.text = _message;
                _GetMessagePanel.gameObject.SetActive(true);
                _tofMessage = false;
            }
            else if (Input.GetButton("Fire1") && _tofMessage && !_redEyeR 
                || Input.GetButton("Fire1") && _tofMessage && !_redEyeL)
            {
                _message = "�Жڂɍg���삪�Ƃ��Ă���";
                _setText.text = _message;
                _GetMessagePanel.SetActive(true);
                _tofMessage = false;
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            _playerSearch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _playerSearch = false;
        _tofMessage = true;
    }

    public void DeerHeads()
    {
        if (_redEyeL && _redEyeR)
        {
            _exit.SetActive(true);
            _message = "���ŉ�������";
            _setText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
        else if (_redEyeL || _redEyeR)
        {
            _message = "�ЖڂɛƂ���";
            _setText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
    }
}
