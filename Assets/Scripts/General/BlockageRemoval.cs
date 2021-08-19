using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlockageRemoval : MonoBehaviour
{
    public int threshold = 0; // How many memories are necessary to clear this?
    public Animator blockAnim; // Fade animation
    public MemoriesManager Memories; // Memories in inventory

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colldied with player"); // test to see if working.
        }
        
        if (other.gameObject.CompareTag("Player") && Memories.puzzleMemories >= threshold)
        {
            blockAnim.SetBool("Fading", true); // Fade animation start
            StartCoroutine(WaitToDestroy()); // Delay so animation can play
            
        }
    }
   
    
    IEnumerator WaitToDestroy()
    {
        GetComponent<BoxCollider2D>().enabled = false; // disables box collider so the player can pass through
        yield return new WaitForSecondsRealtime(4); // 4 seconds of wait real time before the object is then destroyed.
        Destroy(gameObject);
    }

}

