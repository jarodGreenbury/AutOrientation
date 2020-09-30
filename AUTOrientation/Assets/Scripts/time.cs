using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    public Text clock;
    public int timeHour;
    public int day = 0;
    public string timeString;
    public bool dayChanged = false;

    //public DateTime today = System.DateTime.Now;
    public DateTime today = new DateTime(2020, 09, 28, 12, 00, 20);


    void Update()
    {
        //UnityEngine.Debug.Log(today);
        ChangeClock();
        timeString = today.ToString("HH:mm");
        clock.text = ("Day: " + day + " Time: " + timeString).ToString();
        
       //yield WaitForSeconds(0.2f);
        
    }

    void ChangeClock()
    {
        if (today.Hour == 0 && dayChanged == false)
        {
            day += 1;
            dayChanged = true;
        }
        if (today.Hour == 1)
        {
            dayChanged = false;
        }

        TimeSpan newTime = new TimeSpan(0, 0, 0, 6);
        if (!pauseMenu.gameIsPaused)
        {
            today = today + newTime;
        }
    }
}