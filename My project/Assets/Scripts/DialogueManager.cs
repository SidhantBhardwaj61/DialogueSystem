using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI continueButton;
    [SerializeField] String[] dialogues;

    int currentDialogueIndex = 0;
    bool isDialogueActive = false;

    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    public void StartDialogue()
    {
        if(isDialogueActive == false)
        {
            isDialogueActive = true;
            dialoguePanel.SetActive(true);
            dialogueText.text = dialogues[currentDialogueIndex];
            currentDialogueIndex = 0;
        }
    }

    public void AdvanceDialogue()
    {
        if(isDialogueActive == false)
        {
            return;
        }
        
        currentDialogueIndex++;

        if(currentDialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[currentDialogueIndex];
        }
        else
        {
            EndDialogue();
        }
    }

    void EndDialogue()
    {
        isDialogueActive = false;
        dialoguePanel.SetActive(false);
    }
}
