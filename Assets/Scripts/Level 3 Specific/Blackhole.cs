using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blackhole : MonoBehaviour
{
    // Alternative methods used for movement before:
    // other.transform.position = Vector2.Lerp(other.transform.position, EventHorizon.transform.position, Time.deltaTime * 3);
    // Vector3 diff = other.transform.position - EventHorizon.transform.position;
    // other.transform.position -= diff / diff.magnitude * 4;
    
    public Transform otherPos; // The start of the stage
    public KarmaSystem currentKarma; // A reference to the current karma value
    private float originalKarma; // The original karma value upon entering the scene.
    public GameObject EventHorizon; // The approximate center of the black hole.
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(EventHorizon.gameObject.name); // Checks to see if it exists.
    }

    private void OnEnable()
    {
        originalKarma = currentKarma.karmaValue; // Assigns the original karma value.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentKarma.karmaValue = originalKarma; // Resets the karma value to the original value.
            float DistFromHorizon = Vector2.Distance(other.transform.position, EventHorizon.transform.position);
            Debug.Log(DistFromHorizon);
            if (DistFromHorizon > 0.41f)
            {
                // If far enough from the event horizon, pulls them in.
                other.transform.position =
                    Vector2.MoveTowards(other.transform.position, EventHorizon.transform.position, 0.42f);
                
                
            }
            else if(DistFromHorizon <= 0.4f) // If at the event horizon...
            {
                
                
                other.gameObject.transform.position = otherPos.transform.position; // teleports back to the start
                Debug.Log("Stage reset.");
                SceneManager.LoadScene("Third Stage"); // Reloads the stage.
            }
            else
            {
                Debug.Log("Unexpected Error");
            }
        }
    }
}
