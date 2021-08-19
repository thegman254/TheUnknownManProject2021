using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllusionWall : MonoBehaviour
{
    private GameObject wall; // The illusion wall in question
    private GameObject player; // The player 
    public Animator illusionAnim; // The animation controlelr for the illusion wall
    private bool illusionPart1 = false; // First half of the illusion plays.
 

    private SpriteRenderer wallTransparency;
    // Start is called before the first frame update
    void Start()
    {
     wall = GameObject.Find("illusionwall"); // Grabs the illusion wall
     player = GameObject.Find("player"); // Grabs the player

     wallTransparency = wall.GetComponent<SpriteRenderer>(); // Gets the walls' spriterenderer
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Runs the first half of the animation
        illusionPart1 = true; 
        illusionAnim.SetBool("Part1Start", illusionPart1);
        illusionAnim.SetBool("HalfFaded", true);
        //
        
        // Handles the 2nd half of the animation
        float DistFromWall = Mathf.Abs(Mathf.Clamp01(wallTransparency.transform.position.x - player.transform.position.x)); 
        // The above is a rough distance check based on the X axis.
        illusionAnim.SetFloat("Part2Start", DistFromWall);
        //


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        StartCoroutine(cycleOut()); // Stopping the animation
    }

    IEnumerator cycleOut()
    {
        illusionAnim.SetFloat("Part2Start", 1); // sets the condition for this half to false 
        yield return new WaitForSecondsRealtime(1); // waits 1 second
        illusionAnim.SetBool("Part1Start", false); // then sets the 1st half to false to return to normal.
    }
}
