using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class displayName : MonoBehaviour
{
    public Text nameDisplay;
    

    // Update is called once per frame, therefore name is being updated every frame. Must be a better way to do this.
    void Update()
    {
        nameDisplay.GetComponent<Text>().text = "Name: " + enterName.username;
    }
}
