using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Controlls all of the data surrounding the player. Stores health, experience, 
 * deals with updating these calues also. 
 */
public class playerstats : MonoBehaviour
{
    public static int health;
    public static int maxHealth;

    public static int level;
    public static int exp;
    public static int levelExpReq;
    public static bool playerDead;

    public static int collected;
    public static int numCollectibles = 14;

    public levelBar levelbar;
    

    void Start()
    {
        health = 100; //<-Starting Health. 20 for testing. 100 default
        maxHealth = ((level * 2) + 100);
        level = 1; //<-Starting Level. 98 for testing. 1 default
        levelExpReq = ((level * 10) + 50);
        exp = 0;
        collected = 0;
        playerDead = false;
    }
    void Update()
    {
        //UnityEngine.Debug.Log(collected);
        if (Input.GetButtonDown("Jump") && level < 99)
        {
            earnExp(10);
            takeDamage(10);
            //UnityEngine.Debug.Log("Pressed");
        }
        if (exp >= levelExpReq)
        {
            levelUp();
            //UnityEngine.Debug.Log("Levelling Up");
        }
        if (level == 99)
        {
            maxLevel();
        }
        if(health <= 0)
        {
            gameOver();
        }
        achievementCheck();

        //UnityEngine.Debug.Log("Level: "+level);
        //UnityEngine.Debug.Log("Exp: "+exp);
        //UnityEngine.Debug.Log("Req: "+levelExpReq);
        //UnityEngine.Debug.Log("Health: "+health);
        //UnityEngine.Debug.Log("Max: " + maxHealth);
        
    }
   public static void earnExp(int e)
    {
        exp += e;

    }
    void takeDamage(int d)
    {
        health -= d;
        if(health < 0)
        {
            health = 0;
        }
    }

    /*void healPlayer(int h) //For Future Use
    {
        health += h;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        healthbar.setHealth(health);
    }*/
    void levelUp()
    {
        exp -= levelExpReq;
        level++;
        levelExpReq = ((level * 10) + 25);

        maxHealth = ((level * 5) + 100);
        health = maxHealth;
        
    }
    void maxLevel()
    {
        exp = levelExpReq - 1;
    }
    void gameOver()
    {
        playerDead = true;
        SceneManager.LoadScene("Menu");
    }

    void achievementCheck()
    {
        if (level >= 10)
        {
            achievements.a0Complete = true;
        }
        if (level >= 20)
        {
            achievements.a1Complete = true;
        }
        if (level >= 30)
        {
            achievements.a2Complete = true;
        }
        if (level >= 40)
        {
            achievements.a3Complete = true;
        }
        if (level >= 50)
        {
            achievements.a4Complete = true;
        }
    }

}
