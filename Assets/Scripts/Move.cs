using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animation anim;
    public float MoveSpeed = 1;
    public float RunSpeed = 5;
    public float RotationSpeed = 10;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    void Update()
    {

        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow)
            && !Input.GetKey(KeyCode.RightArrow)
            && !Input.GetKey(KeyCode.Space))
        {
            anim.Play("Idle");
            return;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                transform.Translate(Vector3.forward * RunSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.Play("Jump");
            return;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                anim.Play("Run");
            }
            else
            {
                anim.Play("WalkFront");
            }

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.Play("WalkLeft");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.Play("WalkRight");
        }

    }
}