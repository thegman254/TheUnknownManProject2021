﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescboxRaycast2 : MonoBehaviour
{

    /// <summary>
    /// Same as the RayCast without the 2 in front obviously uses the same source attributed for inspiration.
    /// </summary>

    private bool isDisplayed = false;
    public GameObject SecondRayedObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SecondRayedObject.activeSelf.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D Ray2 = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (Ray2.collider.CompareTag("TextShower"))
            {
                isDisplayed = !isDisplayed;
                SecondRayedObject.SetActive(isDisplayed);
                
            }
        }
    
      

       
    }
}
