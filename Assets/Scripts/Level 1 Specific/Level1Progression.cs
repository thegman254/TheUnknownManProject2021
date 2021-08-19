using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Progression : MonoBehaviour
{

        public KarmaSystem karma; // The KarmaSystem.
        public Player player; // The player
        public Text text; // text for "isShowing"
        private bool isShowing; // Text to tell you you're missing memories
        public MemoriesManager Memories; // Amount of memories held

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") && Memories.goodMemories >= 1 || karma.karmaValue > 1) // if either evaluates to true...
            {
                // Load the next part of the good path.
                Destroy(player);
                SceneManager.LoadScene("GoodPath1");

            }
            
            else if (other.gameObject.CompareTag("Player") && Memories.badMemories >= 1 || karma.karmaValue <= -1) // if either evaluates to true...
            {
                // Loads the next part of the bad path.
                Destroy(player);
                SceneManager.LoadScene("BadPath1");

            }
            
          
            else
            {
                isShowing = true; // Loads the text that warns you that you don't have enough memories.
                if (isShowing)
                {
                    StartCoroutine(warningShow()); // Cycles out the text
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        IEnumerator warningShow()
        {
            text.enabled = true; // enables the text
            yield return new WaitForSecondsRealtime(3); // waits 3 seconds
            text.enabled = false; // then disables it
            isShowing = false; // then stops it from looping

        }
}
