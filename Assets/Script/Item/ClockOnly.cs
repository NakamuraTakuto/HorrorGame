using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockOnly : MonoBehaviour
{
    /// <summary>Text設定する</summary>
    [SerializeField, Header("Textを設定する")] GameObject _GetText;
    /// <summary>表示したいTestのImgeを設定する</summary>
    [SerializeField, Header("TextPanelを設定する")] GameObject _getPanel;
    /// <summary>Cloclを設定する</summary>
    [SerializeField, Header("Clockをセットする")] GameObject _clock;
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
            _text.text = "時計の針のようだ";
            _getPanel.SetActive(true);
        }
    }
 }
