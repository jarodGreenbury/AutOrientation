using UnityEngine;
using UnityEngine.SceneManagement;

/* Author: Matthew Blenkinsopp
 * Date Modified : 26/10/2020
 * Purpose: Activates a trigger to exit the car scene and
 * reload the main campus scene
 */
public class carTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}