using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SceneData 
{
    public string SceneName; // Current Scene

    public SceneData(SceneSaver sceneSaver)
    {
        SceneName = sceneSaver.sceneName; // assigning the name of the current scene to this varialbe
    }
}
