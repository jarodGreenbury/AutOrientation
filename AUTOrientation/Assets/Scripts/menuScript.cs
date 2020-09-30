using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject deathScreen;

    void Start()
    {
        if (playerstats.playerDead == true)
        {
            mainMenu.SetActive(false);
            deathScreen.SetActive(true);
        }
    }
    public void quit()
    {
        UnityEngine.Debug.Log("Qutting");
    }
}
