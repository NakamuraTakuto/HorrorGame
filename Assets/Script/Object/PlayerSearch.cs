using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSearch : MonoBehaviour
{
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    [SerializeField, Header("MessagePanelを設定する")] GameObject _GetMessagePanel;
    [SerializeField, Header("メッセージを設定する")] string _message;
    public bool _playerSearch = false;
    bool _tofMessage = true;
    Text _setText;

    private void Start()
    {
        _setText = _GetText.GetComponent<Text>();
    }

    private void Update()
    {
        if (_tofMessage && Input.GetButton("Fire1") && _playerSearch)
        {
            _setText.text = _message;
            _GetMessagePanel.SetActive(true);
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

    public void TrickPainting()
    {
        gameObject.SetActive(false);
    }
}
