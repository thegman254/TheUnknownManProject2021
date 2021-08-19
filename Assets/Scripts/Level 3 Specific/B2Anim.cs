using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B2Anim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator B2Animator; // same as B1
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        B2Animator.SetBool("B2Larger", gameObject.activeInHierarchy); // same as B1
    }
}
