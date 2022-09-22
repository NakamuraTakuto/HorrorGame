using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    bool _triggerToF = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _triggerToF = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
