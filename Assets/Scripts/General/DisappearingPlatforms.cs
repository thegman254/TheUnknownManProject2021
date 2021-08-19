using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Assertions.Must;
using Debug = UnityEngine.Debug;

public class DisappearingPlatforms : MonoBehaviour
{
    public float timer; // The timer for the values changing

    public int onezero; // A value which alternates between 1 and 0 using a XOR.
    private BoxCollider2D box; // The collider for the platform.
    private Color platformColor; // The platforms transparency.
    private float initialTimerValue; // grabs the initial timer value;

    public Sprite[] Sprites; // The activate and inactive sprites of the platform.

    private float r, g, b; // the rbg values of the platform.
    // Start is called before the first frame update
    void Start()
    {
        
       // onezero = 0;
        box = gameObject.GetComponent<BoxCollider2D>();
        platformColor = GetComponent<SpriteRenderer>().material.color;
        
        // rgb of the initial colours
        r = platformColor.r;
        g = platformColor.g;
        b = platformColor.b;
        
        initialTimerValue = timer; // set all the initial values so we don't lose them. 
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1f * Time.deltaTime; // Tick down the timer
        if (timer <= 0f) // If timer is 0...
        {
            onezero ^= 1; // Change from 0 to 1 or 1 to 0. 
            //Debug.Log(onezero.ToString());
            timer = initialTimerValue;  // reset timer to initial timer value.
        }



        



        switch (onezero) // based on whether onezero is 1 or 0.
        {
            case 0:
            {
                gameObject.GetComponent<SpriteRenderer>().material.color = new Color(r, g, b, 1); // If they're "disappeared" then make their colour solid.
                gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[0]; // Disappeared sprite.
                box.enabled = false; // Disable box collider.
                break;
            }
            
            case 1:
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Sprites[1]; // Solid platform sprite.
                platformColor = new Color(r, g, b, Mathf.Clamp01(timer)); // Transparency value clamped to timer as a colour.
                gameObject.GetComponent<SpriteRenderer>().material.color = platformColor;  // setting transparency to colour above.
                box.enabled = true; // Enabling collision.
                box.size = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size; // makes sure that the collider is
                // not the wrong size.
                break;
            }
        }
        
    }
}
