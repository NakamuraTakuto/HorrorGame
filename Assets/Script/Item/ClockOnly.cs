using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockOnly : MonoBehaviour
{
    /// <summary>Text�ݒ肷��</summary>
    [SerializeField, Header("Text��ݒ肷��")] GameObject _GetText;
    /// <summary>�\��������Test��Imge��ݒ肷��</summary>
    [SerializeField, Header("TextPanel��ݒ肷��")] GameObject _getPanel;
    /// <summary>Clocl��ݒ肷��</summary>
    [SerializeField, Header("Clock���Z�b�g����")] GameObject _clock;
    Clock _cloclCom;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _cloclCom = _clock.GetComponent<Clock>();
        _text = _GetText.GetComponent<Text>();
    }

    public void ClockTrigger()
    {
        if (_cloclCom._playerSearch)
        {
            _cloclCom._setToF = true;
        }
        else
        {
            _text.text = "���v�̐j�̂悤��";
            _getPanel.SetActive(true);
        }
    }
 }
