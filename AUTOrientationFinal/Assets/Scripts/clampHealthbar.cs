using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Attaches the healthbar to a placeholder object positioned above the player
 */
public class clampHealthbar : MonoBehaviour
{
    public GameObject healthbar;

    // Update is called once per frame
    void Update()
    {
        Vector3 barPos = Camera.main.WorldToScreenPoint(this.transform.position);
        healthbar.transform.position = barPos;
    }
}
