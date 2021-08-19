using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: might want to make memory manager instead and have both evaluate in the same file. This also works better as I can stick it on ONE thing if I do this.
public class GoodMemory : MonoBehaviour
{
    public int memoryCount;
    public gMemory goodMemories;
   public GameObject[] goodMemoryObjects;
   public bool preset;

   void Awake()
   {
       goodMemories = new gMemory(memoryCount);
   }
   private void Start()
   {
       if (preset)
       {
           goodMemories.goodMemoriesInLevel = goodMemoryObjects;
       }
       else
       {
           Debug.Log("Initialising at runtime somehow.");
           return;
       }
   }

   private void OnCollisionEnter(Collision other)
    {
        foreach (GameObject g in goodMemories.goodMemoriesInLevel)
        {
            if (other.gameObject == g)
            {
                goodMemories.goodMemoresIncrement(other.gameObject);
            }

            else
            {
                return;
            }
        }
    }
}


public class gMemory
{
    private int goodMemoriesCount;
    private int assignmentValue;
    public bool superbMemory;

    
    public int GoodMemoriesCount
    {
        get => goodMemoriesCount;
        set => goodMemoriesCount = value;
    }

    public int AssignmentValue
    {
        get => assignmentValue;
        set => assignmentValue = value;
    }

    public GameObject[] goodMemoriesInLevel;

   

    public gMemory(int mGoodMemoriesCount)
    {
        assignmentValue = AssignmentValue;
        AssignmentValue = mGoodMemoriesCount;
        goodMemoriesInLevel = new GameObject[AssignmentValue];
    }

    public int goodMemoresIncrement(GameObject memory)
    {
        if (memory.CompareTag("Superb"))
        {
            GoodMemoriesCount += 2;
            goodMemoriesCount = GoodMemoriesCount;
            return goodMemoriesCount;
        }
        else
        {
            GoodMemoriesCount++;
            goodMemoriesCount = GoodMemoriesCount;
            return goodMemoriesCount; 

        }
      
    }
    
}

