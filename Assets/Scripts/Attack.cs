using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        anim.Play("attack01");
    }

    void OnTriggerExit(Collider other)
    {
        anim.Play("idle");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") return;
        collision.gameObject.GetComponent<Move>().enabled = false;
        collision.gameObject.GetComponent<Animation>().Play("Death");
        GameObject.Find("TimeoutUI").GetComponent<Timeout>().StopAllCoroutines();
        GameObject.Find("DeathSound").GetComponent<AudioSource>().enabled = true;
        StartCoroutine(Helper.ReloadScene(SceneManager.GetActiveScene().name, 4));
    }
}
