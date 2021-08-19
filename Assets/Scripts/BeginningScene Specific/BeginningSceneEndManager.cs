using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginningSceneEndManager : MonoBehaviour
{

    public DialogueManager isOver; // Checks if dialogue is done
    // Update is called once per frame
    void Update()
    {
        if (isOver.DialogueJustFinished && Input.GetButton("Action")) // if yes...
        {
            isOver.DialogueJustFinished = false;
            SceneManager.LoadScene("First Stage"); // load next scene.
            
        }
    }
}
