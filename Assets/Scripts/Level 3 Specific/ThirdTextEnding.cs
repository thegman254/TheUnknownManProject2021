using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdTextEnding : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogueManager isOver; // Checks if dialogue is done

    void Update()
    {
        if (isOver.DialogueJustFinished && Input.GetButton("Action")) // if yes...
        {
            isOver.DialogueJustFinished = false;
            SceneManager.LoadScene("Fourth Stage"); // load next scene.

        }
    }
}
