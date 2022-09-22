using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField, Header("à⁄ìÆÇµÇΩÇ¢ÉVÅ[Éì")] string _sceneName;
    SceneChanger _scene;
    private void Start()
    {
        _scene = gameObject.GetComponent<SceneChanger>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scene.SeenChange(_sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
