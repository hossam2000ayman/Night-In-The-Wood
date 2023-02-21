using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitWater : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        other.gameObject.GetComponent<Move>().enabled = false;
        other.gameObject.GetComponent<Animation>().Play("Death");
        GameObject.FindGameObjectWithTag("Player_Body").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("TimeoutUI").GetComponent<Timeout>().StopAllCoroutines();
        StartCoroutine(Helper.ReloadScene(SceneManager.GetActiveScene().name, 4));
    }

}
