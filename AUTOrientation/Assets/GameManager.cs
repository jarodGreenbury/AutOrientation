using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public void EndGame ()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Restart();
        }
    }

    private void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

