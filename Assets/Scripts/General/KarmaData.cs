using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class KarmaData 
{
    public float CurrentKarma; // Karma value

    public KarmaData(KarmaSystem karmaSystem)
    {
        CurrentKarma = karmaSystem.karmaValue; // Setting the current karma
        
        Debug.Log("Your current karma is: " + CurrentKarma); // Check to see the system is wokring.
    }
}
