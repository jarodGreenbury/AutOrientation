using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveDialogue : MonoBehaviour
{
    public GameObject NPCDialogue;
    public GameObject PlayerDialogue;
    private bool isCollided;
    private GarryMovement movement;

  
    private void Start()
    {
      
        movement = GetComponent<GarryMovement>();
        NPCDialogue.SetActive(false);
        PlayerDialogue.SetActive(false);
    }
    public void Update()
    {
        
        Debug.Log(isCollided);
        if(Input.GetKeyDown(KeyCode.Q) && isCollided==true)
        {
            isCollided = false;
            movement.speed = 2;
            NPCDialogue.SetActive(false);
            PlayerDialogue.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SetActiveDialogue"))
        {
            movement.speed = 0;
            isCollided = true;
            NPCDialogue.SetActive(true);
            PlayerDialogue.SetActive(true);

        }   
        
    }
    public void OnTriggerExit(Collider other)
    {
        isCollided = false;
        NPCDialogue.SetActive(false);
        PlayerDialogue.SetActive(false);
    }



}
