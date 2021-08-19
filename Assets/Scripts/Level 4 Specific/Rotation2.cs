using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using UnityEngineInternal;


public class Rotation2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Grid RotationGrid; // The grid to rotate.
    private GameObject rotateTele2; // The 2nd rotation teleporter.
    private bool activated = false; // Check to see if this script has already run once.
    public GameObject[] deactivatedThings; // A list of objects to be activated on the 2nd transition.
    public GameObject transition; // The UI object of the white cross fade
    public AudioSource transitionSfx; // The whooshing sound played.
    public Animator transitionFade;  // The white cross fade
    public Transform BG; // rotating the background
    void Start()
    {
        RotationGrid = GameObject.Find("Grid").GetComponent<Grid>(); // Grabbing the grid. 
        rotateTele2 = GameObject.Find("RotationTele2"); // Grabbing the teleporter
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!activated) // If the function hasn't already run...
            {
                StartCoroutine(playAnim()); // Begin the transition
                BG.transform.rotation = quaternion.Euler(0f, 288f, 0f); // Rotates the BG 
                other.transform.position = rotateTele2.transform.position; // Moves the player to the teleporter
                other.transform.rotation = rotateTele2.transform.rotation; //  Sets the rotation of the player to that of the teleporters'
                RotationGrid.transform.position = new Vector3(206.53f, 113.915f, 3.1442f); // Sets the new position of the grid.
                RotationGrid.transform.Rotate(173.55f, -0.0389f, 90f); // Rotates the grid
                activated = true; // Marks this script as having run once.
                foreach (GameObject deactivated in deactivatedThings)
                {
                    // activates all disabled objects in the array.
                    deactivated.SetActive(true);
                }
                StopAllCoroutines(); // End the coroutine for the transition
            }

        }
    }
    
    
    IEnumerator playAnim()
    {
        // Plays the transition and wooshing sound. 
        transition.SetActive(true);
        transitionSfx.Play();
        transitionFade.Play("TransitionFade");
        yield return new WaitForSeconds(0.23f);
        transition.SetActive(false);
    }
}