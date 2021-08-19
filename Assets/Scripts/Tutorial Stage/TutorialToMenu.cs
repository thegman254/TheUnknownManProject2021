using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialToMenu : MonoBehaviour
{
    public void TutorialEnd()
    {
        // upon clicking the back button this is run.
        SceneManager.LoadScene("Loading Screen");
    }
}
