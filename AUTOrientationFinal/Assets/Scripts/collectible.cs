using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: controls the rotation of the coins in game as
 * well as deactivating them once they are triggered by the player
 */
public class collectible : MonoBehaviour
{
    private float z;
[HideInInspector]
    public static int coinsNr;

    public static bool isTrigger = false;
    

 
    void Update()
    {
        //Rotation Function
        z = 100.0f * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, z));
    }

  

    public void OnTriggerEnter(Collider other)
    {
        coinsNr++;
        isTrigger = true;
        Destroy(gameObject, .1f);
    }

 
}
