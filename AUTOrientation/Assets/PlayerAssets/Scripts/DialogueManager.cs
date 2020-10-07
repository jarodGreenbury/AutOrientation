using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Dialogue dialogue;
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;

    private bool isStart = true;
    private bool npcDialogue=false;
    void Start()
    {
        
        sentences = new Queue<string>();
    }
    private void Update()
    {
        
        npcDialogue =!QuestionManager.GarryDialogue;
        if(isStart)
        {
            StartDialogue(dialogue);
            StartCoroutine(WaitForQuestion());
           
        }
        if(Input.GetKeyDown(KeyCode.E) && npcDialogue && !isStart )
        {
            DisplayNextSentence();
            StartCoroutine(WaitForQuestion());
        }    
    }
    IEnumerator WaitForQuestion()
    {
        yield return new WaitForSeconds(.1f);
        QuestionManager.GarryDialogue = true;
       
    }
    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting Conversation with " + dialogue.name);
        isStart = false;
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            
            return;
        }

        
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSpeed(sentence));

    }
    IEnumerator TypeSpeed(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.05f);
        }    
    }    
    void EndDialogue()
    {
        
        isStart = true;
        Debug.Log("End of Conversation");
    }
}
