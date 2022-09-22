using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //[SerializeField, Header("•Ï‚¦‚½‚¢Seen‚ğİ’è")] string _seen;

    public void SeenChange(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
