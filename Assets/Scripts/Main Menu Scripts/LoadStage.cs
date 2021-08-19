using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StageLoad()
    {
        SceneData data = SaveClass.LoadScene(); // Gets the current save files data
        string scene = data.SceneName; // assigns to a scene
        Debug.Log(scene); // Test for correct scene
        SceneManager.LoadScene(scene); // Loads the scene.
    }
}
