using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class TeacherDialogueManager : MonoBehaviour
{

    private Animator anim;


    public NPC npc;

    bool isTalking = false;
    private bool onQuestion = false;

    float distance;
    int curResponseTracker = 0;
    int playerCurResponseTracker = 0;

    [SerializeField]
    private float startWaitTime=2f;
    float waitTime;

    public TextMeshProUGUI Question;
    
    public GameObject QuestionsUI;

    public GameObject[] QuestionManager;

    public GameObject isWrong;

    public GameObject player;

    public GameObject dialogueUI;

    public GameObject npcdialogueUI;

    public Text npcName;
    public Text npcDialogueBox;

    public Text playerName;
    public Text playerResponse;



    void Start()
    {
        
        QuestionsUI.SetActive(false);
        isWrong.SetActive(false);
        
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
                    if (Input.GetKeyDown(KeyCode.E) && isTalking == true && waitTime<=0 && curResponseTracker<2)
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
                  
                    ShowQuestions();
                }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                onQuestion = false;
                EndDialogue();
                QuestionsUI.SetActive(false);
            }
        }
        else
        {
            onQuestion = false;
            QuestionsUI.SetActive(false);
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

    IEnumerator WrongTime()
    {
        isWrong.SetActive(true);
        yield return new WaitForSeconds(1f);
        isWrong.SetActive(false);
    }
    private void EndDialogue()
    {
        anim.GetComponent<Animator>().enabled = true;
        waitTime = 0f;
        isTalking = false;
        npcdialogueUI.SetActive(false);
        dialogueUI.SetActive(false);
    }

    private void ShowQuestions()
    {
        EndDialogue();
        onQuestion = true;
        QuestionsUI.SetActive(true);
        QuestionManager[0].SetActive(true);
        Question.text = "What is a boolean ?";
       
    }

    public void Correct0()
    {
        QuestionManager[0].SetActive(false);
        QuestionManager[1].SetActive(true);
        Question.text = "What is Unity?";
       
    }

    public void Correct1()
    {
        QuestionManager[1].SetActive(false);
        QuestionManager[2].SetActive(true);
        
        Question.text = "What is C#";
        
      
        
    }

    public void Correct2()
    {
        QuestionManager[2].SetActive(false);
        QuestionManager[3].SetActive(true);
        Question.text = "How do you create a clone of an object in Unity?";
    
    }
    public void Correct3()
    {
        QuestionManager[3].SetActive(false);
        QuestionManager[4].SetActive(true);
        Question.text = "Why do you use private in Unity?";
      
    }

    public void Correct4()
    {
        QuestionManager[4].SetActive(false);
        onQuestion = false;
        QuestionManager[0].SetActive(false);
        npcdialogueUI.SetActive(false);
        dialogueUI.SetActive(false);
        
        Question.text = "Good job! You are worthy to study at this college!";
    }

    public void Wrong()
    {
        StartCoroutine(WrongTime());
    }
}
