using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngineInternal;

public class MemoriesManager : MonoBehaviour
{
    // Keeps track of the amount of memories held.
    public int badMemories = 0;
    public int goodMemories = 0;
    public int puzzleMemories = 0;

    // More defunct code of when this was static.
    
    // public static int PuzzleMemories
    // {
    //     get => puzzleMemories;
    //     set => puzzleMemories = value;
    // }
    //
    // public static int GoodMemories
    // {
    //     get => goodMemories;
    //     set => goodMemories = value;
    // }
    //
    // public static int BadMemories
    // {
    //     get => badMemories;
    //     set => badMemories = value;
    // }


    void Start()
    {
        
        
        // Debug.Log(MemoriesManager.BadMemories);
     
   
    }



    // Defunct code of when this was static.
    
    // public static void goodMemoriesIncrease(int value)
    // {
    //
    //     goodMemories += value;
    //     Debug.Log(goodMemories.ToString());
    // }
    //
    // public static void badMemoriesIncrease(int value)
    // {
    //     badMemories += value;
    //     Debug.Log(badMemories.ToString());
    // }
    //
    // public static void puzzleMemoriesIncrease(int value)
    // {
    //     puzzleMemories += value;
    //     Debug.Log(badMemories.ToString());
    // }


    

    private void OnDestroy()
    {
        // When destroyed, memories are reset to 0 just to make sure no errors occur.
        puzzleMemories = 0;
        goodMemories = 0;
        badMemories = 0;
       
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
