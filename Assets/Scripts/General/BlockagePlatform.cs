using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockagePlatform : MonoBehaviour
{

    public GameObject[] startandend = new GameObject[2]; // transforms to move to.
    public GameObject platformObj;  // The platform to move
    public float speed = 1f; // default speed of the platforms
    private bool DirectionChange; // bool the changes once it reaches its destination to enable movement between two transforms.
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      
       //Debug.Log(startandend[Convert.ToByte(scuffedLol)].name);
        float DistFromTrans = Vector2.Distance(platformObj.transform.position,
            startandend[(Convert.ToByte(DirectionChange))].transform.position); // Getting the distance to the platform
        
        //Debug.Log(lol.ToString());

        if (DistFromTrans < 0.001f)
        {
            DirectionChange = !DirectionChange; 
        }
        
        else if (DistFromTrans > 0.001f)
        {
          gameObject.transform.position = Vector2.MoveTowards(platformObj.transform.position,
                startandend[Convert.ToByte(DirectionChange)].transform.position, speed * Time.deltaTime);
            // Moves the platform towards one of the two target transforms
        }

        else
        {
            Debug.Log("Unexpected error");
            // in the event of a weird error
        }
    }

    
    // Below is adapted from Jason Weimann 
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     
    //     if (collision.collider.CompareTag("Player"))
    //     {
    //         Debug.Log("FUCK");
    //         collision.collider.transform.SetParent(transform);
    //     }
    // }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.transform.SetParent(null); 
        }
    }
}
