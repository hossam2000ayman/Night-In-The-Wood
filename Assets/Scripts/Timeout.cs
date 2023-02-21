using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeout : MonoBehaviour
{
    public ProgressBarPro Slider;
    public float TimeOut = 600;
    void Start()
    {
        StartCoroutine(TimeoutPlayer());
    }

    private IEnumerator TimeoutPlayer()
    {
        var end = Time.timeSinceLevelLoad + TimeOut;
        while (Time.timeSinceLevelLoad < end)
        {
            var diff = end - Time.timeSinceLevelLoad;
            Slider.Value = diff / end;
            yield return null;
        }

        var player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Move>().enabled = false;
        player.GetComponent<Animation>().Play("Death");
        StartCoroutine(Helper.ReloadScene(SceneManager.GetActiveScene().name, 4));
    }

}
