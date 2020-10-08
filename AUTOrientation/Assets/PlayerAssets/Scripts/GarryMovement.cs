using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarryMovement : MonoBehaviour
{
    
    static Animator anim2;
    public float speed = 2f;
    public float roationSpeed = 100.0f;
    public float jump = 50f;
    public float speedMultiply = 4f;  //used for multiply the speed

    private float newspeed;  //the speed that will be changed



    private bool playerIsOnTheGround; //be sure the surface to be tagged as Floor, so it can jump
    private Rigidbody rbody;
    void Start()
    {
        newspeed = speed;
        anim2 = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        float translation = Input.GetAxis("Vertical") * newspeed;
        float rotation = Input.GetAxis("Horizontal") * roationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetButtonDown("Jump") && playerIsOnTheGround==true)
        {
            playerIsOnTheGround = false;
            anim2.SetTrigger("isJumping");
            rbody.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);    
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            newspeed = speed*speedMultiply;
            anim2.SetBool("NarutoRunning", true);
        }
        else
        {
            newspeed=speed;
            anim2.SetBool("NarutoRunning", false);
            
        }

      
        if (translation != 0)
        {
            anim2.SetBool("isRunning", true);
            anim2.SetBool("isIdle", false);
        }

        else
        {
            anim2.SetBool("isRunning", false);
            anim2.SetBool("isIdle", true);
        }



    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            playerIsOnTheGround = true;
        }
    }
   
}
