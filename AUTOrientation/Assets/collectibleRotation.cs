using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class collectibleRotation : MonoBehaviour
{
    private float z;

    // Update is called once per frame
    void Update()
    {
        z = 100.0f * Time.deltaTime;
        transform.Rotate(new Vector3(0,0,z));
    }
}
