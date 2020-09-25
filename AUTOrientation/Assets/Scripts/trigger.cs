using UnityEngine;

public class trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
         FindObjectOfType<GameManager>().LoadCarPark();
    }
}