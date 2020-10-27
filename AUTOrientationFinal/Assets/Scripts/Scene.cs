using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
   public void Level1()
    {
        SceneManager.LoadScene(1);
    }
   public void Options()
    {
        SceneManager.LoadScene(2);
    }    
    public void Quit()
    {
        Application.Quit();
    }
}
