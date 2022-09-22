using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    /// <summary>Text�ݒ肷��</summary>
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    /// <summary>�\��������Test��Imge��ݒ肷��</summary>
    [SerializeField, Header("TextPanel��ݒ肷��")] GameObject _getPanel;
    /// <summary>�ڍs��̃V�[��</summary>
    [SerializeField, Header("�ڍs��̃V�[����ݒ肷��")] string _scene;
    /// <summary>Scene�ڍs��Trigger��ToF</summary>
    [SerializeField, Header("�V�[�����ڍs���邽�߂�Trigger")] public bool _setToF = false;
    /// <summary>Player�Ƃ̐ڐG����</summary>
    [SerializeField, Header("Player��������ɂ��邩��ToF")] public bool _playerSearch = false;
    /// <summary>Text��Component���擾���Ă���</summary>
    Text _text;

    private void Start()
    {
        _text = _GetText.GetComponent<Text>();
    }

    private void Update()
    {
        if (_playerSearch && Input.GetButton("Fire1") && !_setToF)
        {
            _text.text = "�j���P�{����Ȃ�";
            _getPanel.SetActive(true);
        }

        if (_setToF)
        {
            SceneManager.LoadScene(_scene);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerSearch = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _playerSearch = false;
    }
}
