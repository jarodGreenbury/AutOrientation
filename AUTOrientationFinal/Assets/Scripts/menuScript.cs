using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Controls the button functionality in the menu. Also makes sure the deathscreen is 
 * active if returning to the menu when the player is dead.
 */
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

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Options()
    {
        SceneManager.LoadScene(3);
    }
}
