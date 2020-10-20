using UnityEngine;
using UnityEngine.SceneManagement;

public class exitCarTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}