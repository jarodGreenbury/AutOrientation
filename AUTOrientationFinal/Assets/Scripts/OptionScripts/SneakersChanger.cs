using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakersChanger : MonoBehaviour
{
    private SkinnedMeshRenderer sneakers;
    public Material[] sneakersMat;

    public static int sneakersnr = 0;

    void Start()
    {
        sneakers = GetComponent<SkinnedMeshRenderer>();

        sneakersnr = PlayerPrefs.GetInt("sneakersnr");

        sneakers.material = sneakersMat[sneakersnr];
    }

    void Update()
    {
        if(sneakersnr>=sneakersMat.Length)
        {
            sneakersnr = 0;
        }
        else
            if(sneakersnr<=-1)
        {
            sneakersnr = sneakersMat.Length - 1;
        }
        else
        {
            sneakers.material = sneakersMat[sneakersnr];
        }    
    }

    public void NextSneakers()
    {
        sneakersnr++;
        PlayerPrefs.SetInt("sneakersnr", sneakersnr);
    }
    public void PreviousSneakers()
    {
        sneakersnr--;
        PlayerPrefs.SetInt("sneakersnr", sneakersnr);
    }


}
