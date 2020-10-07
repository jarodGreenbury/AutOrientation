using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Jarod Greenbury
 * Date Modified : 1/10/20
 * Purpose: This script controls the lamps around the main campus. After
 * 8am the lamps turn off and at 9pm they turn on.
 */

public class lightController : MonoBehaviour
{

    public time dayTime;
    public GameObject lampLight;
    public GameObject lampCone;

    // Start is called before the first frame update
    void Start()
    {
        //Encase player is loaded in at a specfic time.
        if (dayTime.today.Hour < 21 && dayTime.today.Hour > 7)
        {
            lampLight.SetActive(false);
            lampCone.SetActive(false);
        }
        else
        {
            lampLight.SetActive(true);
            lampCone.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if statement to check the time of the clock. Depending on the time the lights are activated.
        if (dayTime.today.Hour < 21 && dayTime.today.Hour > 7)
        {
            lampLight.SetActive(false);
            lampCone.SetActive(false);
        }
        else 
        {
            lampLight.SetActive(true);
            lampCone.SetActive(true);
        }
    }
}
