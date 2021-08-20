using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal;

// Original memory script. Defunct.
public class Memories : MonoBehaviour
{
    public bool isGood = false;

    
    public GameObject Memory;
    // Start is called before the first frame update
    void Start()
    {
        
        // Debug.Log(cunt.gameObject.tag);
        // Debug.Log(cunt.gameObject.name);
        // Debug.Log($"{cunt.gameObject.name} is {isGood.ToString()}" );
    }










    // public int GoodMemoryIncrement(GameObject mem)
    // {
    //     int value = 0;
    //     if (isGood)
    //     {
    //         if (mem.gameObject.CompareTag("Good"))
    //         {
    //             value += 1;
    //             return value ;
    //         }
    //
    //         else if (mem.gameObject.CompareTag("Superb"))
    //         {
    //             value += 2;
    //             return value;
    //         }
    //
    //         else
    //         {
    //             return 0;
    //         }
    //     }
    //
    //     return value;
    // }
    //
    // public int BadMemoryIncrement(GameObject mem)
    // {
    //     int value = 0;
    //     if (!isGood)
    //     {
    //         if (mem.gameObject.CompareTag("Bad"))
    //         {
    //             value += 1;
    //             return value ;
    //         }
    //
    //         else if (mem.gameObject.CompareTag("Awful"))
    //         {
    //             value += 2;
    //             return value;
    //         }
    //
    //         else
    //         {
    //             return 0;
    //         }
    //     }
    //
    //     return value;
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
