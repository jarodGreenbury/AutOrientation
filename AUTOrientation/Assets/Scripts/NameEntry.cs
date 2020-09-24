using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class NameEntry : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    public static string username;

    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text; 
        username = playerName;
        UnityEngine.Debug.Log("Name: " + username);
    }
}
