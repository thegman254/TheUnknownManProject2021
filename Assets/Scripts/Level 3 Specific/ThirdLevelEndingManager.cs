using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdLevelEndingManager : MonoBehaviour
{
    // Start is called before the first frame update
    public KarmaSystem karma; // The KarmaSystem
    public Player player; // The player
    public MemoriesManager Memories; // Amount of memories held
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player") && Memories.goodMemories >= 2 || karma.karmaValue > 1.5) // if either evaluates to true...
        {
            // Load the next part of the good path.
            Destroy(player);
            SceneManager.LoadScene("GoodPath3");

        }

        else if (other.gameObject.CompareTag("Player") && Memories.badMemories  >= 1 || karma.karmaValue <= -1.5) // if either evaluates to true...
        {
            // Load the next part of the bad path.
            Destroy(player);
            SceneManager.LoadScene("BadPath3");

        }

        else if(other.gameObject.CompareTag("Player") && (Memories.badMemories < 1 && Memories.goodMemories < 1) || (karma.karmaValue > -1 && karma.karmaValue < 1)) 
            // if either evaluates to true...
        {
            // Load the next part of the neutral path.
            Destroy(player);
            SceneManager.LoadScene("NeutralPath3");
        }
        
        else
        {
            Debug.Log("Unexpected exception");
        }

    }

}
