using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject returnPoint; // point to warp to.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) // if collision with the player is detected...
        {
            other.gameObject.transform.position = returnPoint.transform.position; // warp back to the return point.
        }
    }
}
