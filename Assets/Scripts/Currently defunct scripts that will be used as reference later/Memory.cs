using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Memory
{
    protected Memory()
    {
        badMemoriesCount = 0;
        awfulbMemory = false;
        BadMemoriesCount = 0;
        

    }



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



    public Memory(int mBadMemoriesCount)
    {
        assignmentValue = AssignmentValue;
        AssignmentValue = mBadMemoriesCount;
        badMemoriesInLevel = new GameObject[AssignmentValue];
    }



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
