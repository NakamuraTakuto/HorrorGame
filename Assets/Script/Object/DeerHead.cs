using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeerHead : MonoBehaviour
{
    public bool _playerSearch = false;
    [SerializeField, Header("EXITを設定する")] GameObject _exit = null;
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    [SerializeField, Header("MessagePanelを設定する")] GameObject _GetMessagePanel;
    [SerializeField, Header("メッセージを設定する")] string _message;
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
                _message = "鹿の両目がない";
                _setText.text = _message;
                _GetMessagePanel.gameObject.SetActive(true);
                _tofMessage = false;
            }
            else if (Input.GetButton("Fire1") && _tofMessage && !_redEyeR 
                || Input.GetButton("Fire1") && _tofMessage && !_redEyeL)
            {
                _message = "片目に紅い珠が嵌っている";
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
            _message = "後ろで音がした";
            _setText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
        else if (_redEyeL || _redEyeR)
        {
            _message = "片目に嵌った";
            _setText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
    }
}
