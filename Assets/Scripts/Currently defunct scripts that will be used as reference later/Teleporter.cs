using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Currently defunct class for a group of teleporters as I needed up not needing it.

[Serializable]
public class Teleporter
{
    public bool isActive;
    public string name;
    Teleporter()
    {
        isActive = false;
    }

    public void SetActive()
    {
        isActive = !isActive; 
    }
}
