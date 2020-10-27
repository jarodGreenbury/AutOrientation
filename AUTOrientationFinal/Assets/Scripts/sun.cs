using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Jarod Greenbury
 * Date Modified : 1/10/20
 * Purpose: This script controls the Sun(main light) to revolve
 * around the level. To be place onto the main level light
 */
public class sun : MonoBehaviour
{
    [HideInInspector]
    public GameObject Sun;
    [HideInInspector]
    public Light SunLight;
 
    [Range(0, 24)]
    public float timeOfDay = 12;
 
    public float secondsPerMinute = 60;
    [HideInInspector]
    public float secondsPerHour;
    [HideInInspector]
    public float secondsPerDay;
 
    public float timeMultiplier = 1;
 
    void Start()
    {
        Sun = gameObject;
        SunLight = gameObject.GetComponent<Light>();
 

    }
 

    void Update()
    {
        SunUpdate();
    }
 
    public void SunUpdate()
    {

        Sun.transform.localEulerAngles = new Vector3(Time.time * timeMultiplier, -30,0);
    }
}
