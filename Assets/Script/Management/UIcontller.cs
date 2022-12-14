using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontller : MonoBehaviour
{
    /// <summary>干渉したいUI</summary>
    [SerializeField, Header("干渉したいUIを設定する")] GameObject _UIset;
    /// <summary>最初にONにするかOFFにするか</summary>
    [SerializeField, Header("UIを最初にONにしておくかOFFにしておくか決定する")] bool _StartOnOff = false;
    // Start is called before the first frame update
    void Start()
    {
        if (_StartOnOff = false)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void UIon()
    {
        _UIset.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
