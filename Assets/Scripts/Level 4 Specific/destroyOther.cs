using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOther : MonoBehaviour
{
    public GameObject otherMemory; // The memory that ISN'T the one picked up in the 4th stage
    // Start is called before the first frame update
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
            // Destroys the memory that isn't the one picked up
            Destroy(otherMemory);
        }
    }
}
