using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject TimeoutUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        other.gameObject.GetComponent<Move>().enabled = false;
        other.gameObject.GetComponent<Animation>().enabled = false;
        GameObject.Find("Audio").SetActive(false);
        WinUI.SetActive(true);
        TimeoutUI.SetActive(false); 
    }
}
