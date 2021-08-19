using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public KarmaSystem karma;
    
    public InventoryAssignment spriteChange; // For the enabling of the sprites.
    private int ind; // The inventory index for assigning sprites
    private bool somethingChanged = false; // checks if a memory was picked up.
    public MemoriesManager Memories; // Updating amount of memories.

    
    // Note: Originally awful vs bad would give you a higher bad memory value. 
    // I realised this was impractical so it was scrapped. The main difference now is karma gain.
    // This isn't really visible in this demo version which is unfortunate.

    // might handle this as a class.
    void Awake()
    {
        ind = 0; // on awake, index is set to 0.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
    
            if (other.gameObject.CompareTag("Bad"))
            {
                somethingChanged = true; // A memory was picked up
                spriteChange.sprites[ind].enabled = true; // Enables the sprite at [ind]
                spriteChange.sprites[ind].sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite; // Changes the sprite
                // at [ind] to the game object hit.
                karma.karmaValue += karma.UpdateKarma(-1); // Updates the current karma value through a KarmaSystem script reference.
                Debug.Log(karma.karmaValue.ToString()); // Logs the karma change.
                Destroy(other.gameObject); // Destroys the memory
                Memories.badMemories++; // Increments total amount of bad memories.
                
                // Defunct code to handle text of the number of memories held
                spriteChange.memoryTotal.text = Mathf.Abs((Memories.goodMemories - Memories.badMemories)).ToString();
                // 
            }

            else if (other.gameObject.CompareTag("Awful"))
            {
                somethingChanged = true; // A memory was picked up
                spriteChange.sprites[ind].enabled = true; // Enables the sprite at [ind]
                spriteChange.sprites[ind].sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite; // Changes the sprite
                // at [ind] to the game object hit.
                karma.karmaValue += karma.UpdateKarma(-2); // Updates the current karma value through a KarmaSystem script reference.
                Debug.Log(karma.karmaValue.ToString()); // Logs the karma change.
                Destroy(other.gameObject); // Destroys the memory
                Memories.badMemories++; // Increments total amount of bad memories.
                
                // Defunct code to handle text of the number of memories held
                spriteChange.memoryTotal.text = Mathf.Abs((Memories.badMemories - Memories.goodMemories)).ToString();
                //
            }

            else if (other.gameObject.CompareTag("Good"))
            {
                somethingChanged = true; // A memory was picked up
                spriteChange.sprites[ind].enabled = true; // Enables the sprite at [ind]
                spriteChange.sprites[ind].sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite; // Changes the sprite
                // at [ind] to the game object hit.
                karma.karmaValue += karma.UpdateKarma(1); // Updates the current karma value through a KarmaSystem script reference.
                Debug.Log(karma.karmaValue.ToString());  // Logs the karma change.
                Destroy(other.gameObject); // Destroys the memory
                Memories.goodMemories++; // Increments total amount of good memories.
                
                // Defunct code to handle text of the number of memories held
                spriteChange.memoryTotal.text = Mathf.Abs((Memories.badMemories - Memories.goodMemories)).ToString();
                //
            }

            else if (other.gameObject.CompareTag("Superb"))
            {
                somethingChanged = true; // A memory was picked up
                spriteChange.sprites[ind].enabled = true; // Enables the sprite at [ind]
                spriteChange.sprites[ind].sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite; // Changes the sprite
                // at [ind] to the game object hit.
                karma.karmaValue += karma.UpdateKarma(2); // Updates the current karma value through a KarmaSystem script reference.
                Debug.Log(karma.karmaValue.ToString()); // Logs the karma change.
                Destroy(other.gameObject); // Destroys the memory
                Memories.goodMemories++; // Increments total amount of good memories.
                
                // Defunct code to handle text of the number of memories held
                spriteChange.memoryTotal.text = Mathf.Abs((Memories.badMemories - Memories.goodMemories)).ToString();
                //
            }
            
            else if (other.gameObject.CompareTag("Puzzle"))
            {
                somethingChanged = true; // A memory was picked up
                spriteChange.sprites[ind].enabled = true; // Enables the sprite at [ind]
                spriteChange.sprites[ind].sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite; // Changes the sprite
                // at [ind] to the game object hit.
                Destroy(other.gameObject); // Destroys the memory
                Memories.puzzleMemories++; // Increments total amount of puzzle memories.
                Debug.Log("Amount of puzzle memories is: " + Memories.puzzleMemories.ToString()); // Debugs the amount of
                // puzzle memories held.
              

            }

            if (somethingChanged)
            {
                ind++; //  Moves the index of the array forward essentially.
             
            }

            somethingChanged = false; // sets something changed to false after everything else.


    }
}
