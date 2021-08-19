using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBlackHolesRed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] BlackHole; // The black holes to be enabled
    public GameObject TextBox; // A text box that appears when collided with.
    public Animator TextBoxAnim; // Animator for that appearance.

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DescBoxAppear()); // Starts the appearing of the text box.
            
            //enables both black holes.
            BlackHole[0].SetActive(true);
            BlackHole[1].SetActive(true);
            
            
            StopCoroutine(DescBoxAppear()); // stops the above coroutine.
        }
        
    }

    IEnumerator DescBoxAppear()
    {
        TextBox.SetActive(true); //enables the black hole
        TextBoxAnim.Play("TextBox_UnfadeLevel3"); // plays the animation
        yield return null;
    }
}
