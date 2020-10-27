using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
        slider.value = playerstats.health;
        slider.maxValue = playerstats.maxHealth;
    }
}

