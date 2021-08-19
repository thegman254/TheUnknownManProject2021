using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour // test script purely to see how OnEnable works
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("Stage Loaded!"); 
        }
    }
}
