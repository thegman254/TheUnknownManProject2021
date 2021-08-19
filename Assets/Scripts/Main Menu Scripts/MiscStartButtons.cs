using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiscStartButtons : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameEnd()
    {
        // On clinking the quit button runs this
        Application.Quit();
    }

    public void CutsceneLoad()
    {
        // On clinking the example cutscene button runs this
        SceneManager.LoadScene("FirstCutscene");
    }

    public void BeginTutorial()
    {
        // On clinking the tutorial button runs this
        SceneManager.LoadScene("Tutorial");
    }
}
