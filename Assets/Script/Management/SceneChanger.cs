using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //[SerializeField, Header("変えたいSeenを設定")] string _seen;

    public void SeenChange(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
