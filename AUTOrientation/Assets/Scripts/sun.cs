using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Jarod Greenbury
 * Date Modified : 1/10/20
 * Purpose: This script controls the sun(main light) to revolve
 * around the level. To be place onto the main level light
 */
public class sun : MonoBehaviour
{
    //is the speed of the day
    public float speed;
    public float nightSpeed;
    public Transform sunLight;

    // Update is called once per frame
    void Update()
    {
        if (sunLight.position.y < -350)
        {
            UnityEngine.Debug.Log("speed 20");
            speed = 20f;
        }
       /* else
        {
            speed = speed;
        }*/
        //code changes the position and rotation of the sun(directional light)
        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
