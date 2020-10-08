using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCDialogue
{
    public string npcname;
    [TextArea(3,10)]
    public string[] npcsentences;
    
}
