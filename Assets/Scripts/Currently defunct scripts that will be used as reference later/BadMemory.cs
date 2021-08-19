using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// note: might want to make memory manager instead and have both evaluate in the same file. This also works better as I can stick it on ONE thing if I do this.
public class BadMemory : MonoBehaviour
{
    public int memoryCount;
    public bMemory badMemories;
   public GameObject[] badMemoryObjects;
   public bool preset;


   private void Awake()
   {
       badMemories = new bMemory(); 
   }
   
   private void Start()
   {
       if (preset)
       {
           badMemories.badMemoriesInLevel = badMemoryObjects;
       }
       else
       {
           Debug.Log("Initialising at runtime somehow.");
           return;
       }
   }

   private void FixedUpdate()
   {
   }

   private void OnCollisionEnter2D(Collision2D other)
    {
        for (int i = 0; i < badMemoryObjects.Length; i++)
        {
            Destroy(badMemoryObjects[i].gameObject);
        }
        // foreach (GameObject g in badMemories.badMemoriesInLevel)
        // {
        //
        //     if (other.gameObject.CompareTag("Player"))
        //     {
        //         Debug.Log("Fuck");
        //         Destroy(g);
        //     }
        //     else
        //     {
        //         return;
        //     }
        //         
        //     
        //
        //     
        // }
    }
}

public class bMemory : Memory
{
    private int badMemoriesCount;
    private int assignmentValue;
    public bool awfulbMemory;

    public int BadMemoriesCount
    {
        get => badMemoriesCount;
        set => badMemoriesCount = value;
    }

    public int AssignmentValue
    {
        get => assignmentValue;
        set => assignmentValue = value;
    }

    public GameObject[] badMemoriesInLevel;

   

    // public  bMemory(int mBadMemoriesCount)
    // {
    //     assignmentValue = AssignmentValue;
    //     AssignmentValue = mBadMemoriesCount;
    //     badMemoriesInLevel = new GameObject[AssignmentValue];
    // }

    public int badMemoriesIncrement(GameObject memory)
    {
        if (memory.CompareTag("Awful"))
        {
           BadMemoriesCount += 2;
           badMemoriesCount = BadMemoriesCount;
            return badMemoriesCount;
        }
        else
        {
            BadMemoriesCount++;
            badMemoriesCount = BadMemoriesCount;
            Debug.Log("Lag");
            return badMemoriesCount; 

        }
      
    }
    
}