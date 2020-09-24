using UnityEngine;

public class trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
    
         Debug.Log("we hit");
         FindObjectOfType<GameManager>().LoadCarPark();
    }
}