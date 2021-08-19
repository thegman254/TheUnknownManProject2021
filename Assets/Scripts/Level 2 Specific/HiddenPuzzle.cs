using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator hiddenPuzzleAnim; // Animator for the hidden uzzle
    void Awake()
    {
        hiddenPuzzleAnim.SetBool("Faded", true); // Hides the puzzle memory upon awake.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hiddenPuzzleAnim.SetBool("Faded", false); // Makes the puzzle memory appear.
        }
        

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hiddenPuzzleAnim.SetBool("Faded", true); // Makes the puzzle memory disappear again.
        }

    }
}
