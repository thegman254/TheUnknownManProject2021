using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1Anim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator B1Animator; // Black hole 1 animator
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        B1Animator.SetBool("B1Larger", gameObject.activeInHierarchy); // Makes the animation start once the game object
        // is enabled
    }
}
