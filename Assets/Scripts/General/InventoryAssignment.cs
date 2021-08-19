using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class InventoryAssignment : MonoBehaviour
{
    
    public Image[] sprites; // The memory sprites.
    public Text inventoryText; // defunct text value
    public Text memoryTotal; // The total amount of memories
    public Text pathText; // The "path" you're going along. This is replaced by the karma bar now.
   
    // currently defunct values
    public KarmaSystem karma; 
    public Transform newPos;
    private Transform currentPos;
    //
    
    // Start is called before the first frame update
    void Start()
    {
        currentPos = pathText.transform;  // This just updates where path text would've been.
        
        
        // Disables all images until needed.
        foreach (Image img in sprites)
        {
            img.enabled = false; 
        }
    }
    // for (int i = 0; i < sprites.Length; i++)
            // {
            //     
            //     sprites[i].sprite = inv.heldEmotions[i];
            //     sprites[i].transform.localScale = new Vector3(0.5f, 0.5f);
            // }
            //

    // Update is called once per frame
    
    // This handled the path text.
    void Update()
    {
        // if (MemoriesManager.BadMemories > MemoriesManager.GoodMemories)
        // {
        //     pathText.transform.position = currentPos.transform.position; 
        //     pathText.text = "Bad \n Memories";
        // }
        //
        // if (MemoriesManager.BadMemories == MemoriesManager.GoodMemories)
        // {
        //     pathText.transform.position = newPos.transform.position;
        //     pathText.text = "Neutral";
        // }
        //
        // if (MemoriesManager.BadMemories < MemoriesManager.GoodMemories)
        //
        // {
        //     pathText.transform.position = currentPos.transform.position; 
        //     pathText.text = "Good \n Memories";
        // }
    }
}
