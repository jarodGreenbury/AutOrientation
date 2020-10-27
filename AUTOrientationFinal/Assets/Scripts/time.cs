using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

/* Author: Jarod Greenbury
 * Date Modified : 1/10/20
 * Purpose: This script controls the in game clock. The purpose of this script is 
 * to control the clock which provides ques for other scripts. Eg. lamps.
 */

public class time : MonoBehaviour
{
    public Text clock;
    public int timeHour;
    public int day = 1;
    public string timeString;
    public bool dayChanged = false;

    //public DateTime today = System.DateTime.Now;
    public DateTime today = new DateTime(2020, 09, 28, 7, 00, 20);


    void Update()
    {
        //calls function to update the clocks time
        ChangeClock();
        timeString = today.ToString("HH:mm");
        clock.text = ("Day: " + day + " Time: " + timeString).ToString(); //display the time to the GUI
        achievementCheck();
       //yield WaitForSeconds(0.2f);
        
    }

    void ChangeClock()
    {
        // counts the days passed in game. Based off 24 hr clock
        if (today.Hour == 0 && dayChanged == false)
        {
            day += 1;
            dayChanged = true;
        }
        if (today.Hour == 1)
        {
            dayChanged = false;
        }

        TimeSpan newTime = new TimeSpan(0, 0, 0, 3);
        if (!pauseMenu.gameIsPaused)
        {
            today = today + newTime;
        }
    }
    void achievementCheck()
    {
        if(day == 5)
        {
            achievements.a5Complete = true;
        }
        if (day == 10)
        {
            achievements.a6Complete = true;
        }
        if (day == 15)
        {
            achievements.a7Complete = true;
        }
        if (day == 20)
        {
            achievements.a8Complete = true;
        }
    }
}