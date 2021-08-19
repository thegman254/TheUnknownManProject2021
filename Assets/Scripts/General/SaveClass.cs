using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// credit to Brackeys -> https://www.youtube.com/watch?v=XOjd_qU2Ido

public static class SaveClass
{
    

    public static void SaveScene(SceneSaver sceneSaver)
    {
        BinaryFormatter bf = new BinaryFormatter(); // making a binary formatter
        string path = Application.persistentDataPath + "Scene.sav"; // the file to save to
        FileStream fs = new FileStream(path, FileMode.Create); // Where to create the file
        
        SceneData data = new SceneData(sceneSaver); // This makes the SceneData.
        
        bf.Serialize(fs, data); // This then encrypts that data.
        fs.Close(); // closing the file stream
    }
    
    public static void SaveKarma(KarmaSystem karmaSaver) // Same as above but for KarmaData
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "Karma.sav";
        FileStream fs = new FileStream(path, FileMode.Create);
        
        KarmaData data = new KarmaData(karmaSaver);
        
        bf.Serialize(fs, data);
        fs.Close();
    }

    public static SceneData LoadScene()
     {
         string path = Application.persistentDataPath + "Scene.sav"; // path to save file
         if (File.Exists(path)) // Checks if the save exists
         {
             BinaryFormatter bf = new BinaryFormatter(); // Makes a formatter for deserializing
             FileStream fs = new FileStream(path, FileMode.Open); // Opens the file
             SceneData data = bf.Deserialize(fs) as SceneData; // Deserializes into a new SceneData variable
             fs.Close(); // closes file stream
             return data; // Gives the data to where it was called for.
         }
         else
         {
             // Debug logs this if no file detected
             Debug.Log("No SceneData found");
             return null;
         }
     }

     public static KarmaData LoadKarma() // Same as above but for KarmaData.
     {
         string path = Application.persistentDataPath + "Karma.sav";
         if (File.Exists(path))
         {
             BinaryFormatter bf = new BinaryFormatter();
             FileStream fs = new FileStream(path, FileMode.Open);
             KarmaData data = bf.Deserialize(fs) as KarmaData;
             fs.Close();
             return data;
         }
         else
         {
             Debug.Log("No KarmaData found");
             return null;
         }    
     }
     
}
