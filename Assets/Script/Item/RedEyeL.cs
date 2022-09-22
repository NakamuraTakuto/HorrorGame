using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedEyeL : MonoBehaviour
{
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    [SerializeField, Header("MessagePanel��ݒ肷��")] GameObject _GetMessagePanel;
    [SerializeField, Header("���b�Z�[�W��ݒ肷��")] string _message;
    [SerializeField, Header("�֌W�̂���Obj��ݒ肷��")] GameObject _SetRelationObj;
    Text _SetText;
    DeerHead _deerHead;
    BottonPop _bottonOff;

    private void Start()
    {
        _SetText = _GetText.GetComponent<Text>();
        _deerHead = _SetRelationObj.GetComponent<DeerHead>();
        _bottonOff = GetComponent<BottonPop>();
    }
    public void Relation()
    {
        if (_deerHead._playerSearch)
        {
            _deerHead._redEyeL = true;
            _deerHead.DeerHeads();
            _bottonOff._setUI.SetActive(false);
            Destroy(gameObject);
        }
        else if (_deerHead._playerSearch == false)
        {
            _SetText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
    }

    private void OnDestroy()
    {
        _bottonOff._setUI.SetActive(false);
    }
}
