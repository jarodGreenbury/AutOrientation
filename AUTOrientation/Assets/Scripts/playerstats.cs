using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerstats : MonoBehaviour
{
    public static int health;
    public static int maxHealth;

    public static int level;
    public static int exp;
    public static int levelExpReq;
    public static bool playerDead;

    public levelBar levelbar;
    

    void Start()
    {
        health = 100;
        maxHealth = ((level * 5) + 100);
        level = 1; //<-Starting Level. 98 for testing purposes
        levelExpReq = ((level * 10) + 25);
        exp = 0;
        playerDead = false;
    }
    void Update()
    {
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

        //UnityEngine.Debug.Log("Level: "+level);
        //UnityEngine.Debug.Log("Exp: "+exp);
        //UnityEngine.Debug.Log("Req: "+levelExpReq);
        //UnityEngine.Debug.Log("Health: "+health);
        //UnityEngine.Debug.Log("Max: " + maxHealth);
        
    }
   void earnExp(int e)
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
}
