using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadPathProgression : MonoBehaviour

{
    
    // This handled the bad path progression for the demo level
    
    // Start is called before the first frame update
    public KarmaSystem karma;
    public Player player;
    
    

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Player") && karma.karmaValue <= -1 || MemoriesManager.BadMemories >= 2)
    //     {
    //         Destroy(player);
    //         SceneManager.LoadScene("BadPath1");
    //
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
