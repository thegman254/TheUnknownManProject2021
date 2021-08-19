using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantForRotation : MonoBehaviour
{
    
    // Start is called before the first frame update
    private GameObject player; // The player
    private Transform tileGrid; // the grid transform.
    void Start()
    {
        player = GameObject.Find("player"); // Grabbing the player
        tileGrid = GameObject.Find("Grid").GetComponent<Transform>(); // Grabbing the grid
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Once colliding with the player parent the player to the grid.
            other.transform.SetParent(tileGrid, true);   
        }
       
    }
}
