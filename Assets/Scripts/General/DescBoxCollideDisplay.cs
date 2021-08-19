using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class DescBoxCollideDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextToAppear; // The text that will appear open collision
    public float time; // how long the text is displayed.
   

 

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        StartCoroutine(setBox()); // Starts the display coroutine
        StopCoroutine(setBox()); // Ends it.
    }

    IEnumerator setBox()
    {
        TextToAppear.SetActive(true); // Enables the text game object.
        yield return new WaitForSecondsRealtime(time); // Waits for a couple of real time seconds for the player to read it...
        TextToAppear.SetActive(false); // Disables it.
    }
}
