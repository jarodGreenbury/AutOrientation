using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairChanger : MonoBehaviour
{
    private SkinnedMeshRenderer hair;
    public Material[] hairMat;
    public static int hairnr = 0;

    void Start()
    {
        hair = GetComponent<SkinnedMeshRenderer>();

        hairnr = PlayerPrefs.GetInt("hairnr");

        hair.material = hairMat[hairnr];
    }

    void Update()
    {
        
        if(hairnr>=hairMat.Length)
        {
            hairnr = 0;
        }
        else
        if(hairnr<=-1)
        {
            hairnr = hairMat.Length-1;
        }
        else
        {
            hair.material = hairMat[hairnr];
        }
    }

    public void NextHair()
    {
        hairnr++;
        PlayerPrefs.SetInt("hairnr", hairnr);
    }
    public void PreviousHair()
    {
        hairnr--;
        PlayerPrefs.SetInt("hairnr", hairnr);
    }

}
