using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedEyeL : MonoBehaviour
{
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    [SerializeField, Header("MessagePanelを設定する")] GameObject _GetMessagePanel;
    [SerializeField, Header("メッセージを設定する")] string _message;
    [SerializeField, Header("関係のあるObjを設定する")] GameObject _SetRelationObj;
    Text _SetText;
    DeerHead _deerHead;

    private void Start()
    {
        _SetText = _GetText.GetComponent<Text>();
        _deerHead = _SetRelationObj.GetComponent<DeerHead>();
    }
    public void Relation()
    {
        if (_deerHead._playerSearch)
        {
            _deerHead._redEyeL = true;
            _deerHead.DeerHeads();
            Destroy(gameObject);
        }
        else if (_deerHead._playerSearch == false)
        {
            Debug.Log("yobareta");
            _SetText.text = _message;
            _GetMessagePanel.SetActive(true);
        }
    }
}
