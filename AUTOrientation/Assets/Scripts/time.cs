using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    public Text clock;
    public int timeHour;
    public int day = 1;
    public string timeString;

    //public DateTime today = System.DateTime.Now;
    public DateTime today = new DateTime(2020, 09, 28, 12, 00, 20);


    void Update()
    {
        //UnityEngine.Debug.Log(today);
        timeString = today.ToString("HH:mm");
        clock.text = ("Day: " + day + " Time: " + timeString);
        ChangeClock();
       //yield WaitForSeconds(0.2f);
        
    }

    void ChangeClock()
    {
        if (today.Hour > 23 )
        {
            day = day + 1;
        }
        TimeSpan newTime = new TimeSpan(0, 0, 0, 6);
        if (!pauseMenu.gameIsPaused)
        {
            today = today + newTime;
        }
    }
}