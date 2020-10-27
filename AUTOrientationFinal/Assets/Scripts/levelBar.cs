using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public TextMeshProUGUI expDisplay;
    public Text levelDisplay;

    void Start()
    {


    }
    void Update()
    {
        slider.maxValue = playerstats.levelExpReq;
        slider.value = playerstats.exp;
        if (playerstats.level < 10)
        {
            levelDisplay.text = "0" + playerstats.level.ToString();
        }
        else
        {
            levelDisplay.text = playerstats.level.ToString();
        }
        if (playerstats.level >= 99)
        {
            expDisplay.text = "Max Level";
        }
        else
        {
            expDisplay.text = slider.value + "/" + slider.maxValue;
        }

        //UnityEngine.Debug.Log(slider.value + "/" + slider.maxValue);

    
    }
    
}
