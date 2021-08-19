using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionEnabler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] JumpPads; // The jump pads to be changed
    private List<JumpPad> ExtensionEnable = new List<JumpPad>(); // A list of jumpads
    void Start()
    {
        // sets up the list
        JumpPads = GameObject.FindGameObjectsWithTag("JumpPad");
        foreach (GameObject obj in JumpPads)
        {
            ExtensionEnable.Add(obj.GetComponent<JumpPad>());
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Enables extension jump for all jump pads in the scene upon collision with the player.
            foreach (JumpPad ext in ExtensionEnable)
            {
                ext.ExtendJump = true;
            }
        }
    }
}
