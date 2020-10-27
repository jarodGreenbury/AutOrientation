using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Constantly updates, keeping the helthbar
 * on screen equivalent to the player health in the playerstats script
 */
public class healthBar : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        slider.value = playerstats.health;
        slider.maxValue = playerstats.maxHealth;
    }
}

