using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] TutorialImages; // The images used in the tutorial
    public GameObject TutorialImageObject; // The game object for the tutorial image
    private int ind; // Indexer for the array.
    void Start()
    {
        ind = 0; // set index to 0
        TutorialImageObject.GetComponent<Image>().sprite = TutorialImages[0]; // make sure the image is the first image

    }
    
    public void GoForward()
    {
        if (ind != 4) // if not highest index...
        {
            ind++; // increment index
            TutorialImageObject.GetComponent<Image>().sprite = TutorialImages[ind]; // change tutorial picture to the new index value.
        }
        else
        {
            // If you try to go forward at max index
            Debug.Log("Right is empty");
        }
    }

    public void GoBackward()
    {
        if (ind != 0) // if not lowest index...
        {
            ind--;
            TutorialImageObject.GetComponent<Image>().sprite = TutorialImages[ind]; // change tutorial picture to the new index value.
        }
        else
        {
            // If you try to go backwards at min index
            Debug.Log("Left is empty");
        }
    }
}
