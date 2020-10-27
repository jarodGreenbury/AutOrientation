using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

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
