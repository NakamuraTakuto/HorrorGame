using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanPaintign : MonoBehaviour
{
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    [SerializeField, Header("MessagePanel��ݒ肷��")] GameObject _GetMessagePanel;
    [SerializeField, Header("���b�Z�[�W��ݒ肷��")] string _message;
    [SerializeField, Header("�֌W�̂���Obj��ݒ肷��")] GameObject _SetRelationObj;
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
