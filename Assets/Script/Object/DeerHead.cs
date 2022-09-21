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
                _message = "鹿の両目がない";
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
            _message = "後ろで音がした";
            _setText.text = _message;
        }
        else if (_redEyeL || _redEyeR)
        {
            _message = "片目に嵌った";
            _setText.text = _message;
        }
    }
}
