using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOff : MonoBehaviour
{
    [SerializeField] GameObject _GetPanel;
    public void TextOffButton()
    {
        gameObject.SetActive(false);
    }
}
