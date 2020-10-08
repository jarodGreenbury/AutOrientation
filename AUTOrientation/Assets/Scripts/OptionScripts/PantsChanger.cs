using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsChanger : MonoBehaviour
{
    private SkinnedMeshRenderer pants;
    public Material[] pantsMat;

    public static int pantsnr = 0;

    void Start()
    {
        pants = GetComponent<SkinnedMeshRenderer>();

        pantsnr = PlayerPrefs.GetInt("pantsnr");

        pants.material = pantsMat[pantsnr];
    }

    void Update()
    {
        if(pantsnr>=pantsMat.Length)
        {
            pantsnr = 0;
        }
        else
            if(pantsnr<=-1)
        {
            pantsnr = pantsMat.Length - 1;
        }
        else
        {
            pants.material = pantsMat[pantsnr];
        }    
    }

    public void NextPants()
    {
        pantsnr++;
        PlayerPrefs.SetInt("pantsnr", pantsnr);
    }
    public void PreviousPants()
    {
        pantsnr--;
        PlayerPrefs.SetInt("pantsnr", pantsnr);
    }


}
