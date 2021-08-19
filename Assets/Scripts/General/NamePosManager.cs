using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamePosManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    // To acknowledge: Yes, this code is not the best.
    // To further: I don't really know how better to do this so this is why this exists.

    private Text posNeedingManaging; // The text to move.
    public Transform name1Pos; // First transform for managing position.
    public Transform name2Pos; // Second transform for managing position.
    public string[] namesForMatching; // Names to find to determine which need moving where.
    public Transform name3Pos; // Third transform for managing position.

   
    // Update is called once per frame

    private void Start()
    {
        posNeedingManaging = GameObject.Find("Text").GetComponent<Text>(); // Gets the text component
                                                                           // of the name displaying text in the scene
                                                                           
        Debug.Log(namesForMatching[0]); // makes sure that the names are working correctly

    }

    void Update()
    {
        if (posNeedingManaging.text == namesForMatching[0]) // Logic for element 0
        {
            posNeedingManaging.gameObject.SetActive(false); // supposed to vanish and reappear but basically doesn't really.
            // Same applies to all below this one.
            posNeedingManaging.transform.position = name1Pos.transform.position; // moving the text to transform position at element 0
            posNeedingManaging.gameObject.SetActive(true);
            
                
            
        }
        
        else if (posNeedingManaging.text == namesForMatching[1])
        {
            posNeedingManaging.gameObject.SetActive(false);
            posNeedingManaging.transform.position = name2Pos.transform.position; // moving the text to transform position at element 1
            posNeedingManaging.gameObject.SetActive(true);
            



        }

        else if((name3Pos != null && namesForMatching.Length > 2) &&  posNeedingManaging.text == namesForMatching[2]) // Checks if
        // even necessary.
        {
             posNeedingManaging.gameObject.SetActive(false);
             posNeedingManaging.transform.position = name3Pos.transform.position; // moving the text to transform position at element 2
             posNeedingManaging.gameObject.SetActive(true);
             

        }
    }
    
    
    
    
}
