using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
    public bool _playerSearch = false;
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        _playerSearch = true;
    }

    public void TrickPainting()
    {
        gameObject.SetActive(false);
    }
}
