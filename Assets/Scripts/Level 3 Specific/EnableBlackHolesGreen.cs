using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBlackHolesGreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] BlackHole; // The black holes to enable
    public GameObject Blockage; // A blockage that appears to block the player from an easy way out.
    public Animator Level3BlockageAnimator; // The animator for the blockage.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(BlockageEnable()); // Fades in the blockage
            
            // enables both black holes.
            BlackHole[0].SetActive(true); 
            BlackHole[1].SetActive(true);
            
            StopCoroutine(BlockageEnable()); // Stops the coroutine
        }
        
    }

    IEnumerator BlockageEnable() 
    {
        Blockage.SetActive(true); // enables the blockage
        yield return new WaitForSeconds(0.1f); // Takes a small pause to allow the game object to be registered and not null.
        Level3BlockageAnimator.Play("TextBox_UnfadeLevel3"); // Plays the fade in animation.
    }
}
