using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class deathScript : MonoBehaviour
{
    public Text namelevel;

    // Start is called before the first frame update
    void Start()
    {
        namelevel.text = "NAME: " + enterName.username + "\nLEVEL: " + playerstats.level + "\nFINAL SCORE:\n" + playerstats.level * playerstats.exp;
    }
}
