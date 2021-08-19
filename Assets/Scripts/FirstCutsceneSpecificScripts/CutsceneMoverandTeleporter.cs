using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class CutsceneMoverandTeleporter : MonoBehaviour
{
    private GameObject endPoint; // Destination for "The Unknown Man" to reach in the cutscene

    private GameObject originPoint; // Above's origin point.

    private Vector2 zero = Vector2.zero; // value used in smoothing.

    public Animator CutsceneAnimator; // controls when the "The Unknown Man" will start running

    private int endReachedCounter = 0; // how many times has the end been reached?

    public int maxNum = 5; // prevention of infinite counting
    

    private AudioSource[] audioSources; // The audio sources used.

    public FirstSceneSfx sfx = new FirstSceneSfx(); // The class for handling the sfx of the first scene

    private Vector2 playerX; // The player's X pos.

    private bool isRunning = false; // Once true makes the player move faster towards the end point.

    private Vector2 endpointX;
    // Start is called before the first frame update
    void Awake()
    {
        audioSources = GameObject.FindObjectsOfType<AudioSource>(); // getting the audiosources in the scene.
        Array.Reverse(audioSources); // Unsure why it's necessary but, reversing the Array is important otherwise the sfx play backwards.
    }


    void Start()
    {
        
        endPoint = GameObject.Find("EndPoint"); // Finds the end marker transform.
        originPoint = GameObject.Find("OriginPoint"); // Finds the origin marker transform.
        sfx.setupAudioFromArray(audioSources); // Sets up the sfx audio from the reversed array.
        sfx.AudioList(); // Tells me the audio I've loaded in.
        endpointX = new Vector2(endPoint.transform.position.x, -1.67f); // Sets the endpoint at a specific X to avoid transforming through the Y axis.

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector2.Distance(transform.position, endPoint.transform.position); // Distance between the player and end marker transform.
        if (dist <= 0.32) 
        {
            transform.position = originPoint.transform.position; // Go back to the beginning of the level
            
            if (endReachedCounter <= maxNum) 
            {
                endReachedCounter++; 
                CutsceneAnimator.SetInteger("EndedCounter", endReachedCounter); // assigns the integer as once it's higher than 2 the player changes to a run animation.
                sfx.playSfx(); // plays the current loaded sfx, dequeues and loads the next one.
            }


        }

        Debug.Log(dist.ToString());

        if (endReachedCounter > 2)
        {
            isRunning = true; // player will move faster from point A to B
        }

        if (!isRunning)
        {
            transform.position = Vector2.SmoothDamp(transform.position, endpointX, ref zero, 1.1f, 9f);
            // Walking speed SmoothDamp movement to point B
        }
        
        else if (isRunning)
        {
            transform.position = Vector2.SmoothDamp(transform.position, endpointX, ref zero, 1.1f, 11f);
            // Running speed SmoothDamp movement to point B

        }

        else
        {
            Debug.Log("Unexpected Error"); 
            // In case of an unaccounted for error.
        }
    }
}
