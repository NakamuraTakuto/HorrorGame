using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //[SerializeField, Header("�ς�����Seen��ݒ�")] string _seen;

    public void SeenChange(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
