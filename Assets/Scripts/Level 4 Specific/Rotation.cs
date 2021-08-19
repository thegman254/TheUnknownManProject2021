using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    private Grid RotationGrid; // grid for rotation
    private GameObject rotateTele1; // Teleporting the player to the new position of the grid
    private bool activated = false; // has the teleport happened already?
    public Animator transitionFade; // The white cross fade
    public GameObject transition; // The UI object of the white cross fade
    public AudioSource transitionSfx; // The whooshing sound played.
    void Start()
    {
        RotationGrid = GameObject.Find("Grid").GetComponent<Grid>(); // Grabbing the grid of level 4
        rotateTele1 = GameObject.Find("RotationTele"); // Grabbing the first rotation teleporter 
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!activated) // If the function hasn't already run...
            {
                StartCoroutine(playAnim()); // Begin the transition
                other.transform.Rotate(0f, 0f, 92.255f); // Rotating the player
                other.transform.position = rotateTele1.transform.position; // Moving the player to the new position
                RotationGrid.transform.position = new Vector3(131, 75, 0); // The new position of the grid
                RotationGrid.transform.Rotate(0f, 0f, -89.659f); // The new rotation of the grid
                activated = true; // Label it as having ran once.
                StopCoroutine(playAnim()); // End the coroutine for the transition
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
