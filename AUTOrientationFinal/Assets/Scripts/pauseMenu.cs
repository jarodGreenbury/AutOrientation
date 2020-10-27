using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Controls the logic of the pause menu. Deals with stopping 
 * and starting in-game time as well as changing the scene and active
 * scene elemants where necessary.
 */
public class pauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject playerGUI;
    public GameObject pauseMenuPage;
    public GameObject achievementsPage;
    public bool isMuted;

    // Update is called once per frame
    void Start()
    {
        Resume();
        isMuted = false;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   

    public void muteSound()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }

    public void Resume()
    {
        pauseMenuPage.SetActive(true);
        achievementsPage.SetActive(false);
        pauseMenuUI.SetActive(false);
        playerGUI.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        playerGUI.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Quit(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
