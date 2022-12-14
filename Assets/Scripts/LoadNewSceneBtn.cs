using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNewSceneBtn : MonoBehaviour
{
    public void LoadNewScene(string sceneName)
    {
        Debug.Log(sceneName + " is loading");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        Debug.Log(sceneName + " has loaded");
    }

}
