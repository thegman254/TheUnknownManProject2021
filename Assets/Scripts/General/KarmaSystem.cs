using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarmaSystem : MonoBehaviour
{
    
    public float karmaValue;
    private Vector3 _transformPosition;
    public Animator KarmaAnimator;
    private static readonly int Unfade = Animator.StringToHash("Unfade");
    
    // Originally planned to use for the karma bar. The animator fully replaced it.
    public GameObject arrow;
    public GameObject pos1;
    public GameObject neg1;
    ////////////////////////////////////////////////////////////////////////////////
    
    void Update()
    {
        // checks for changes in the karma value per frame.
        KarmaAnimator.SetFloat("Karma", karmaValue);
    }

    public float UpdateKarma(int incomingKarmaValue)
    {
        // Takes the value passed in from the player code and divides by 4 before returning the value.
        float newVal = (float) incomingKarmaValue / 4;
        return newVal;
        
    }
    
    

    private void OnDestroy()
    {
        SaveClass.SaveKarma(this); // Saves the karma upon destroy being called
    }

    private void OnEnable()
    {
        LoadKarma(); // Loading the karma upon enable.
        Debug.Log("Your current karma is: " + karmaValue); // check to see that it worked.
    }

    public void LoadKarma()
    {
        KarmaData data = SaveClass.LoadKarma(); // Grabbing the data for the karma from its serialized state...
        karmaValue = data.CurrentKarma; // Assigning said data.
        
    }

    // Update is called once per frame
   

 
}
