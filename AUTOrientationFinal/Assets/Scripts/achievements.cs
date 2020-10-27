using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Stores individual booleans to track when each of the achievements has been completed. 
 */
public class achievements : MonoBehaviour
{
    public Text collectibleText;
    public GameObject achievement0; //level10
    public GameObject achievement1; //level20
    public GameObject achievement2; //level30
    public GameObject achievement3; //level40
    public GameObject achievement4; //level50
    public GameObject achievement5; //day5
    public GameObject achievement6; //day10
    public GameObject achievement7; //day15
    public GameObject achievement8; //day20
    public GameObject achievement9; //carfirst
    public GameObject achievement10; //mhfirst

    public static bool a0Complete;
    public static bool a1Complete;
    public static bool a2Complete;
    public static bool a3Complete;
    public static bool a4Complete;
    public static bool a5Complete;
    public static bool a6Complete;
    public static bool a7Complete;
    public static bool a8Complete;
    public static bool a9Complete;
    public static bool a10Complete;

    // Start is called before the first frame update
    void Start()
    {
        a0Complete = false;
        a1Complete = false;
        a2Complete = false;
        a3Complete = false;
        a4Complete = false;
        a5Complete = false;
        a6Complete = false;
        a7Complete = false;
        a8Complete = false;
        a9Complete = false;
        a10Complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerstats.collected == playerstats.numCollectibles)
        {
            collectibleText.text = "ALL COLLECTIBLES FOUND";
        }
        else
        {
            collectibleText.text = "Collectibles Found: " + playerstats.collected;
        }
        
        if (a0Complete)
        {
            achievement0.SetActive(true);
        }
        if (a1Complete)
        {

            achievement1.SetActive(true);
        }
        if (a2Complete)
        {
            achievement2.SetActive(true);

        }
        if (a3Complete)
        {
            achievement3.SetActive(true);

        }
        if (a4Complete)
        {
            achievement4.SetActive(true);

        }
        if (a5Complete)
        {
            achievement5.SetActive(true);

        }
        if (a6Complete)
        {
            achievement6.SetActive(true);

        }
        if (a7Complete)
        {
            achievement7.SetActive(true);

        }
        if (a8Complete)
        {
            achievement8.SetActive(true);

        }
        if (a9Complete)
        {
            achievement9.SetActive(true);

        }
        if (a10Complete)
        {
            achievement10.SetActive(true);

        }
    }
}
