using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteraction : MonoBehaviour
{
    public Sprite dialogueBoxSprite;
    public GameObject dialogueBox;
    //public AudioSource audioSource;

    //public AudioClip dialogueSound;

    public Dialog dialogue;
    public bool isDialogueTrigger = false;
    public bool isInDistance = false;

    public GameObject FragmentHolder;

    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        FragmentHolder = GameObject.Find("FragmentHolder");
        FragmentHolder.SetActive(false);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInDistance = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInDistance = false;
        
       FindObjectOfType<DialogueManager>().animator.SetInteger("BoxState", 3);
        //audioSource.Stop();
        isDialogueTrigger = false;
        
    }

    private void Update()
    {
        if (isInDistance)
        {
            if (Input.GetKeyDown(/*GameManager.instance.keybinds.dictionary["Dialogue"]*/ KeyCode.E))
            {
               
                if (isDialogueTrigger)
                {
                    FindObjectOfType<DialogueManager>().DisplayNextSentence();
                }
                else
                {
                    dialogueBox.transform.GetComponent<Image>().sprite = dialogueBoxSprite;
                    TriggerDialogue();
                    isDialogueTrigger = true;
                }
            }
            
        }

    }


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
