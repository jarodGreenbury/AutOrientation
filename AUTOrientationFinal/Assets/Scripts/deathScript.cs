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

    // Start is called before the first frame update
    void Start()
    {
        namelevel.text = "NAME: " + enterName.username + "\nLEVEL: " + playerstats.level + "\nFINAL SCORE:\n" + playerstats.level * playerstats.exp;
    }
}
