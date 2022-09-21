using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTestInhertance : MonoBehaviour
{
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    [SerializeField, Header("MessagePanelを設定する")] GameObject _GetMessagePanel;
    [SerializeField, Header("メッセージを設定する")] string _message;
    Text _SetText;

    private void Start()
    {
        _SetText = _GetText.GetComponent<Text>();
    }
    public void Message()
    {
        _SetText.text = _message;
        _GetMessagePanel.SetActive(true);
    }
}
