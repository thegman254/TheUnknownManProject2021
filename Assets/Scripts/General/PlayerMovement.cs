using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

// Credit to Brackeys -> https://www.youtube.com/watch?v=dwcT-Dch0bA
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; // Character controller so movement can be controlled.
    private float horizontalMove = 0f; // Value used for getting the horizontal movement by getting the horizontal axis 
    // then multiplying it with the runSpeed.
    public float runSpeed = 20f; // Run/Walk speed
    public bool jump = false; // Is the player jump?
    public Animator charAnim; // The character animator
    private AudioSource[] sources; // The jump and run sounds. [1] is run and walk and [0] is jump
    private AnimatorStateInfo jumpAnim; // For checking if the jump animation is playing


    private void Start()
    {
        sources = GetComponentsInChildren<AudioSource>(); // getting the run, walk and jump sfx.
        Debug.Log($"The first source is: {sources[0].clip.name} and the seconds is {sources[1].clip.name}");
        // Checking the correct audio has loaded


    }

    public void StepPlay()
    {
        sources[1].pitch = UnityEngine.Random.Range(0.7f, 1f); // Change pitch per step
        sources[1].volume = 0.33f; // Set volume to 33% of original
        sources[1].Play();
    }
    
    // Update is called once per frame
    void Update()
    {

       
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            runSpeed = 40f; // run speed.
        }
        else
        {
            runSpeed = 20f; // walk speed
        }
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; // Value for the character controller.
       //Debug.Log(horizontalMove.ToString());
      charAnim.SetFloat("Speed", Mathf.Abs(horizontalMove)); // Sets whether the player is running or walking.

       
       
       
       if (Input.GetButtonDown("Jump"))
       {
   
           jump = true; // makes the player jump
           charAnim.SetBool("Jumping", jump); // sets the animation to jumping
           if (!jumpAnim.IsName("Player_Jump")) // If the players animation state isn't junp...
           {
               sources[0].Play(); // Play the jump sound.
           }

       }
    }

    public void OnLanding()
    {
        
        charAnim.SetBool("Jumping", false); // sets the jump bool to false for the animator.


    }

    private void FixedUpdate()
    {
       
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump); // Passing values to the character controller
        // to control movement.
        jump = false; // Disables the jump bool
        jumpAnim = charAnim.GetCurrentAnimatorStateInfo(0); // Gets the state info of the 0th layer index of the char animator.

    }


    IEnumerator Jumping() // This was a theoretical coroutine to stop the error that happens occurs when you press space bar
    // Twice during one jump.
    // It was semi successful but had a weird problem itself where occasionally it just wouldn't activate.
    {
        yield return new WaitWhile(() => jumpAnim.IsName("Player_Jump"));
        charAnim.SetBool("Jumping", true);
    }





}
