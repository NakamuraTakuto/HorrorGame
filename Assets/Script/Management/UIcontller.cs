using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontller : MonoBehaviour
{
    /// <summary>��������UI</summary>
    [SerializeField, Header("��������UI��ݒ肷��")] GameObject _UIset;
    /// <summary>�ŏ���ON�ɂ��邩OFF�ɂ��邩</summary>
    [SerializeField, Header("UI���ŏ���ON�ɂ��Ă�����OFF�ɂ��Ă��������肷��")] bool _StartOnOff = false;
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
