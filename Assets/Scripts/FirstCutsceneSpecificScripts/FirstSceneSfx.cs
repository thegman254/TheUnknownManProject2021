using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FirstSceneSfx
{

    private Queue<AudioSource> sfx = new Queue<AudioSource>(5);

    public List<AudioSource> loader = new List<AudioSource>();

    public void setupAudio()
    {
        foreach (AudioSource source in loader)
        {
            if (source != null)
            {
                sfx.Enqueue(source);
            }
            
        }
    }

    public void setupAudioFromArray(AudioSource[] sources)
    {
        foreach (AudioSource source in sources)
        {
            sfx.Enqueue(source);
        }
        
    }

    public void AudioList()
    {
        foreach (AudioSource source in sfx)
        {
            if (sfx.Count > 0)
            {
                Debug.Log(source);
            }

            else
            {
                Debug.Log("Sorry no sfx could be loaded!");
            }
            
        }
    }
    
    public void playSfx()
    {
        if (sfx.Count > 0)
        {
            sfx.Peek().Play();
            Debug.Log("The sound: " + sfx.Peek().ToString() + " was just played.");
            sfx.Dequeue();
        }

        else
        {
            Debug.Log("No clips in queue!");
        }
    }
}
