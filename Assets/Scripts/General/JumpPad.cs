using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject playerObj; // The player
    private PlayerMovement movement; // The players movement code
    private AudioSource Boing; // The fun boing sound
    private bool extendedJump = false; // Should the jump go further than normal or not?
    public float JPadJump = 2800f; // Jump pad's standard jump velocity
    public float ExtendedJump = 4100f; // The extended jump velocity
    public bool ExtendJump
    {
        get { return extendedJump; }
        set { extendedJump = value; } // Entirely for enabling the extension via the puzzle memory in level 2.
    }
    
    void Start()
    {
        playerObj = GameObject.Find("player"); // Gets the player
        movement = playerObj.GetComponent<PlayerMovement>(); // and his movement script from him.
        Boing = GetComponent<AudioSource>(); // Gets the boing sfx from the object.
    }

    // Update is called once per frame
    void Update()
    {
        // Test to see if extended jump activated properly.
        if (extendedJump == true)
        {
            Debug.Log("Extended Jump enabled");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        movement.jump = true; // This is supposed to set the jump variable to true but it doesn't really work.
        
        if (!Boing.isPlaying)
        {
            Boing.Play(); // Plays the sound.
        }

        if (!extendedJump)
        {
            other.rigidbody.AddForce(new Vector2(0, JPadJump)); // Adds normal force to the player.
        }
        else
        {
            other.rigidbody.AddForce(new Vector2(0, ExtendedJump)); // Adds extended force to he player.
        }
    }
}
