using UnityEngine;
using UnityEngine.SceneManagement;

public class carTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}