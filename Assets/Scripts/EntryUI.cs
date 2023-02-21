using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryUI : MonoBehaviour
{
    public GameObject AboutUI;
    public void Play()
    {
        var seceneList = new List<string> { "Play1", "Play2", "Play3" };
        SceneManager.LoadScene(seceneList[Random.Range(0, 3)]);
    }
    
    public void About()
    {
        AboutUI.SetActive(true);
    }
    
    public void CloseAbout()
    {
        AboutUI.SetActive(false);
    }
}
