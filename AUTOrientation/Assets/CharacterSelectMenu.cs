using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectMenu : MonoBehaviour
{
    public void StartGame(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
