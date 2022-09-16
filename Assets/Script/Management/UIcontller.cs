using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontller : MonoBehaviour
{
    /// <summary>Š±Â‚µ‚½‚¢UI</summary>
    [SerializeField, Header("Š±Â‚µ‚½‚¢UI‚ğİ’è‚·‚é")] GameObject _UIset;
    /// <summary>Å‰‚ÉON‚É‚·‚é‚©OFF‚É‚·‚é‚©</summary>
    [SerializeField, Header("UI‚ğÅ‰‚ÉON‚É‚µ‚Ä‚¨‚­‚©OFF‚É‚µ‚Ä‚¨‚­‚©Œˆ’è‚·‚é")] bool _StartOnOff = false;
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
