using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: controls the collecting and storing of the player's name in the menu.
 */
public class enterName : MonoBehaviour
{
    // Start is called before the first frame update
    public static string username;
    public GameObject inputField;

    public void StoreName()
    {
        username = inputField.GetComponent<Text>().text;
        //UnityEngine.Debug.Log("Name: " + username);
    }
}
