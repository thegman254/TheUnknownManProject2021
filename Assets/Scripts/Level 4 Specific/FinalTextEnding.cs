﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTextEnding : MonoBehaviour
{
    public DialogueManager isOver; // Checks if dialogue is done
    void Update()
    {
        if (isOver.DialogueJustFinished && Input.GetButton("Action")) // if yes...
        {
            isOver.DialogueJustFinished = false;
            SceneManager.LoadScene("Final Words"); // load next scene.
            
        }
    }
}
