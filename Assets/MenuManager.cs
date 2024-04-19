using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public string sceneName1;
    public string sceneName2;
    public string sceneName3;
    private int level = 0;

    public void ChangeScene()
    {
        if (level == 0) { 
            SceneManager.LoadScene(sceneName1);
        }
        
        if(level == 1)
        {
            SceneManager.LoadScene(sceneName2);
        }

        if(level == 2)
        {
            SceneManager.LoadScene(sceneName3);
        }
    }

    public void MenuChanged(int value)
    {
        level = value;
    }

    public void exitGame() {
        Application.Quit();
    }
}
