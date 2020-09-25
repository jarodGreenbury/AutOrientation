using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerstats : MonoBehaviour
{
    public int health;

    public static int level;
    public static int exp;
    public static int levelExpReq;

    public levelBar levelbar;

    void Start()
    {
        health = 100;
        level = 98; //<-Starting Level. 98 for testing purposes
        levelExpReq = ((level * 10) + 25);
        exp = 0;
        levelbar.setExp(exp);
        levelbar.setMaxExp(levelExpReq);
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && level < 99)
        {
            earnExp(10);
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
        
        //UnityEngine.Debug.Log("Level: "+level);
        //UnityEngine.Debug.Log("Exp: "+exp);
        //UnityEngine.Debug.Log("Req: "+levelExpReq);
        
    }
   void earnExp(int e)
    {
        exp += e;
        levelbar.setExp(exp);

    }
    void levelUp()
    {
        exp -= levelExpReq;
        level++;
        levelExpReq = ((level * 10) + 25);
        levelbar.setExp(exp);
        levelbar.setMaxExp(levelExpReq);
    }
    void maxLevel()
    {
        exp = levelExpReq - 1;
        levelbar.setExp(exp);
    }
}
