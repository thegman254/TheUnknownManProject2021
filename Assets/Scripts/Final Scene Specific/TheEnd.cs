using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public DialogueManager isOver; // Checks if dialogue is done
    // Start is called before the first frame update
    void Update()
    {
        if (isOver.DialogueJustFinished && Input.GetButton("Action")) // if yes...
        {
            isOver.DialogueJustFinished = false;
            Application.Quit(); // Quits the game.
            
        }
    }
}
