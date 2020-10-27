using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Controls all functionality of the death screen.
 * Functionality currently limited to name and score.
 */
public class deathScript : MonoBehaviour
{
    public Text namelevel;
    private int playerLevel;
    private int playerExp;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        playerLevel = playerstats.level;
        playerExp = playerstats.exp;
        score = calculateScore(playerLevel, playerExp);
        namelevel.text = "NAME: " + enterName.username + "\nLEVEL: " + playerstats.level + "\nFINAL SCORE:\n" + score;
    }

    public int calculateScore(int lvl, int exp)
    {
        int temp = 0;
        for (int i = 0; i <= lvl; i++)
        {
            temp = temp + (i * exp);
        }
        return temp;
    }
}
