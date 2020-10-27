using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoodieChanger : MonoBehaviour
{
    private SkinnedMeshRenderer hoodie;
    public Material[] hoodieMat;

    public static int hoodienr = 0;

    void Start()
    {
        hoodie = GetComponent<SkinnedMeshRenderer>();

        hoodienr = PlayerPrefs.GetInt("hoodienr");

        hoodie.material = hoodieMat[hoodienr];
    }

    void Update()
    {
        if(hoodienr>=hoodieMat.Length)
        {
            hoodienr = 0;
        }
        else
            if(hoodienr<=-1)
        {
            hoodienr = hoodieMat.Length - 1;
        }
        else
        {
            hoodie.material = hoodieMat[hoodienr];
        }    
    }

    public void NextHoodie()
    {
        hoodienr++;
        PlayerPrefs.SetInt("hoodienr", hoodienr);
    }
    public void PreviousHoodie()
    {
        hoodienr--;
        PlayerPrefs.SetInt("hoodienr", hoodienr);
    }


}
