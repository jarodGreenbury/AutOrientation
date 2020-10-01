using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Dialogue dialogue;
    public Text nameText;
    public Text dialogueText;
    public static bool GarryDialogue = true;

    private Queue<string> sentence;
    private bool isStart = true;
    
    void Start()
    {
        sentence = new Queue<string>();
    }
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && isStart && GarryDialogue==true)
        {
            StartDialogue(dialogue);
            StartCoroutine(WaitForQuestion());
            
        }
        if(Input.GetKeyDown(KeyCode.E) && !isStart && GarryDialogue == true)
        {
            DisplayNextSentence();
            StartCoroutine(WaitForQuestion());
        }

        IEnumerator WaitForQuestion()
        {
            yield return new WaitForSeconds(.1f);
            GarryDialogue = false;

        }
    }
    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting Conversation with " + dialogue.name);
        isStart = false;
        nameText.text = dialogue.name;

        sentence.Clear();

        foreach (string sentences in dialogue.sentences)
        {
            sentence.Enqueue(sentences);
        }

        
    }
    public void DisplayNextSentence()
    {
        if(sentence.Count == 0)
        {
            EndDialogue();
            
            return;
        }

        
        string sent = sentence.Dequeue();
        dialogueText.text = sent;

    }
    void EndDialogue()
    {
        
        isStart = true;
        Debug.Log("End of Conversation");
    }
}
