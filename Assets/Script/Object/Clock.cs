using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    /// <summary>Text設定する</summary>
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    /// <summary>表示したいTestのImgeを設定する</summary>
    [SerializeField, Header("TextPanelを設定する")] GameObject _getPanel;
    /// <summary>移行先のシーン</summary>
    [SerializeField, Header("移行先のシーンを設定する")] string _scene;
    /// <summary>Scene移行のTriggerのToF</summary>
    [SerializeField, Header("シーンを移行するためのTrigger")] public bool _setToF = false;
    /// <summary>Playerとの接触判定</summary>
    [SerializeField, Header("Playerが判定内にいるかのToF")] public bool _playerSearch = false;
    /// <summary>TextのComponentを取得してくる</summary>
    Text _text;

    private void Start()
    {
        _text = _GetText.GetComponent<Text>();
    }

    private void Update()
    {
        if (_playerSearch && Input.GetButton("Fire1") && !_setToF)
        {
            _text.text = "針が１本足りない";
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
