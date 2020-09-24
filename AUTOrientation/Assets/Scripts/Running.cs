using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    static Animator anim2;
    public float speed = 10.0f;
    public float runningSpeed = 20.0f;
    public float roationSpeed = 100.0f;
    void Start()
    {
        anim2 = GetComponent<Animator>();
    }


    void Update()
    {
        bool running = Input.GetKey(KeyCode.LeftShift);

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * roationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (Input.GetButtonDown("Jump"))
        {
            anim2.SetTrigger("isJumping");
        }

        else if (translation != 0)
        {
            speed = 10.0f;
            anim2.SetBool("isRunning", false);
            anim2.SetBool("isWalking", true);
            anim2.SetBool("isIdle", false);

            if (translation != 0 && running)
            {
                speed = 30.0f;
                anim2.SetBool("isRunning", true);
                anim2.SetBool("isWalking", false);
                anim2.SetBool("isIdle", false);

            }
        }


        else
        {
            anim2.SetBool("isRunning", false);
            anim2.SetBool("isWalking", false);
            anim2.SetBool("isIdle", true);
        }



    }

}

