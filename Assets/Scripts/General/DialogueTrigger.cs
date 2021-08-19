using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

// Credit to Brackeys. -> https://www.youtube.com/watch?v=_nRzoTzeyxU

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue; // The dialogue class to use
    public bool isAuto = true; // Does the dialogue automatically start?
    

    void Awake()
    {
        
    }
    
    private void Start()
    {
        
        if (isAuto) // if it should start by itself...
        {
            FindObjectOfType<DialogueManager>().nameSetup(dialogue); // Set up the names immediately
            StartCoroutine(BufferTime()); // Then wait for 0.1 seconds as otherwise an error happens 
            // of it not being able to find the object
        }


        else
        {
            return; 
            // just wait for the player to press Z.
        }
    }

    private void OnEnable() // As all scenes need dialogue regardless of starting or not.
    {
        if(dialogue.names.Length < 1)  // Does it have any names assigned right now?
        FindObjectOfType<DialogueManager>().nameSetup(dialogue); // If no, set up the names.
    }

    IEnumerator BufferTime() // This is just a simple pause script so null object shenanigans don't happen.
    {
        yield return new WaitForSeconds(0.1f); 
        Debug.Log("loading message");
        TriggerDialogue();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            TextForward(); // Displays the next sentence by grabbing the DialogueManager.
        }
    }

    
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue); // grabs the dialogue manager and starts the dialogue.
       // DialogueManager.Instance.StartDialogue(dialogue);
        
    }

    public void TextForward()
    {
        //StopCoroutine(BufferTime());
        FindObjectOfType<DialogueManager>().DisplayNextSentence(); // Same as above but for moving the text forward.
    }


}
