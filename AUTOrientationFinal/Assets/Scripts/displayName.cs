using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Shows the player name entered in the menu on the GUI in-game
 */
public class displayName : MonoBehaviour
{
    public Text nameDisplay;
    

    // Update is called once per frame, therefore name is being updated every frame. Must be a better way to do this.
    void Start()
    {
        nameDisplay.GetComponent<Text>().text = "Name: " + enterName.username;
    }
}
