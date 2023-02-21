using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{

    
    void Start()
    {

    }

    public void ReloadScene()
    {
        StartCoroutine(Helper.ReloadScene(SceneManager.GetActiveScene().name, 0));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
