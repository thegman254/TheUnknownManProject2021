using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohhnyTest : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Destroy(gameObject); // This was used to destroy the blackage in the demo level so the puzzle memory test could
            // be accessed.
        }
    }
}
