using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanPaintign : MonoBehaviour
{
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    [SerializeField, Header("MessagePanelを設定する")] GameObject _GetMessagePanel;
    [SerializeField, Header("メッセージを設定する")] string _message;
    [SerializeField, Header("関係のあるObjを設定する")] GameObject _SetRelationObj;
    Text _SetText;
    PlayerSearch _playerSearch;

    private void Start()
    {
        _SetText = _GetText.GetComponent<Text>();
        _playerSearch = _SetRelationObj.GetComponent<PlayerSearch>();
    }
    public void Relation()
    {
        if (_playerSearch._playerSearch)
        {
            _playerSearch.TrickPainting();
        }
        else
        {
            _SetText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
    }
}
