using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentence;

    void Start()
    {
        sentence = new Queue<string>();
    }

   public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting Conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentence.Clear();

        foreach (string sentences in dialogue.sentence)
        {
            sentence.Enqueue(sentences);
        }

        DisplayNextSentence();
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
        Debug.Log("End of Conversation");
    }
}
