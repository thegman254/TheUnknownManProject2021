using UnityEngine;
using UnityEngine.SceneManagement;

namespace DemoLevel_Specific
{
    
    // Begins the neutral path progression.
    public class SecretPathProgressionLvl1 : MonoBehaviour
    {
        // Start is called before the first frame update
        public KarmaSystem karma; // KarmaSystem reference.
        public Player player; // The player
        public MemoriesManager Memories; // Memories held
    

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") && Memories.puzzleMemories == 3) // If you hold three puzzle memories
            // and go to the secret portal...
            {
                // Then you start the neutral path.
                Destroy(player);
                SceneManager.LoadScene("NeutralPath1");

            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}