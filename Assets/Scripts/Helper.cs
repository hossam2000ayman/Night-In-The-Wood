using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Helper
{
    public static IEnumerator ReloadScene(string scene, float timeOut)
    {
        yield return new WaitForSeconds(timeOut);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
