using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTestInhertance : MonoBehaviour
{
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    [SerializeField, Header("MessagePanel��ݒ肷��")] GameObject _GetMessagePanel;
    [SerializeField, Header("���b�Z�[�W��ݒ肷��")] string _message;
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
