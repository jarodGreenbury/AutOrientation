using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
    public GameObject Canteen;

    private void Start()
    {
        Canteen.SetActive(false);
    }

    public void Update()
    {
      
        
    }

    private void OnTriggerEnter(Collider other)
    {
     Canteen.SetActive(true);

    }
}
