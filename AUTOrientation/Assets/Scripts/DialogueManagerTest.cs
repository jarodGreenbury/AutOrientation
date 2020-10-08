using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManagerTest : MonoBehaviour
{

    private Animator anim;

    public NPC npc;

    bool isTalking = false;

    float distance;
    int curResponseTracker = 0;
    int playerCurResponseTracker = 0;

    [SerializeField]
    private float startWaitTime=2f;
    float waitTime;


    public GameObject player;

    public GameObject dialogueUI;

    public GameObject npcdialogueUI;

    public Text npcName;
    public Text npcDialogueBox;

    public Text playerName;
    public Text playerResponse;



    void Start()
    {
        waitTime = startWaitTime;

        npcdialogueUI.SetActive(false);
        dialogueUI.SetActive(false);

        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        distance = Vector3.Distance(player.transform.position,this.transform.position);
        if (distance <= 10f)
        {
       
                
                if (isTalking == false)
                {
                    StartConversation();
                }
                else
                    if (Input.GetKeyDown(KeyCode.E) && isTalking == true && waitTime<=0)
                {
                    ContinueConversation();
                waitTime = startWaitTime;
                }
            else
            {
                waitTime -= Time.deltaTime;
            }
                if (curResponseTracker >= npc.dialogue.Length)
                {
                    EndDialogue();
                }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                EndDialogue();
            }
        }
        else
        {
            EndDialogue();
            npcdialogueUI.SetActive(false);
            dialogueUI.SetActive(false);
            anim.GetComponent<Animator>().enabled = true;
        }    
    }

    private void StartConversation()
    {
        anim.GetComponent<Animator>().enabled = false;
        isTalking = true;
        curResponseTracker = 0;
        npcdialogueUI.SetActive(true);
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        playerName.text = npc.PlayerName;
        npcDialogueBox.text = npc.dialogue[0];
        playerResponse.text = npc.playerDialogues[0];
    }

    private void ContinueConversation()
    {
        anim.GetComponent<Animator>().enabled = false;
        waitTime = startWaitTime;
            curResponseTracker++;
            npcName.text = npc.name;
        playerName.text = npc.PlayerName;

        StartCoroutine(WaitTime());
         

    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0f);
        npcDialogueBox.text = npc.dialogue[curResponseTracker];
        yield return new WaitForSeconds(1f);
        playerResponse.text = npc.playerDialogues[curResponseTracker];
    }
    private void EndDialogue()
    {
        anim.GetComponent<Animator>().enabled = true;
        waitTime = 0f;
        isTalking = false;
        npcdialogueUI.SetActive(false);
        dialogueUI.SetActive(false);
    }
}
