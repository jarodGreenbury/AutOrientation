using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
