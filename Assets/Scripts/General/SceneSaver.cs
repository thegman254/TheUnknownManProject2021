using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSaver : MonoBehaviour
{
    [HideInInspector]
    public Scene scene; // The scene that needs to be reference
    [HideInInspector]
    public string sceneName; // string that will take the scenes name.
    // Start is called before the first frame update

    private void Awake()
    {
        scene = SceneManager.GetActiveScene(); // Get the scene
        sceneName = scene.name; // Assign the scene name to the string
        SaveClass.SaveScene(this); // Save the current scene on awake.
    }

    private void OnEnable()
    {
        
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
