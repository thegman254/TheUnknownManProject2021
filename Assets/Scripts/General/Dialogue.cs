using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Credit to Brackeys. -> https://www.youtube.com/watch?v=_nRzoTzeyxU

[System.Serializable]
public class Dialogue
{

    [TextArea(3, 10)]
    public string[] sentences; // The sentences that end up being displayed.

    public string[] names; // The array of names used 


    

    Dialogue(string nameForChar, string[] presetSentences) // Constructor if able to provide preset sentences and names.
    {
        
        sentences = presetSentences;
        
    }

    Dialogue(string nameForChar) // Constructor if somehow there was a name preset for the character
    {
       
    }

    Dialogue(string[] presetSentences) // Constructor for just preset sentences.
    {
        sentences = presetSentences;
    }

    Dialogue() // default constructor.
    {
        UnityEngine.Debug.Log("Default constructor called.");
        
    }







}
