using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryRevealer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UnrevealedMemory; // A superb memory in the stage
    public Animator MemoryAnim; // The animation controller for this memory.
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        UnrevealedMemory.SetActive(true); // Enables the memory
        MemoryAnim.SetBool("GreenFaded", true); // then plays the unfade animation.
    }
}
