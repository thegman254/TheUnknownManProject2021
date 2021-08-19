using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


// inspired by Brackeys refer to any dialogue related code for credits.

/// <summary>
/// Was supposed to for description boxes that had multiple boxes. I never ended up finding use for this as the description
/// boxes I do have are singular bits of text.
/// </summary>


public class DescriptionBoxes : MonoBehaviour
{
    private int index = 0;
    [TextArea(3,10)]
    public string[] sentences;
    public Text DescBox;
    
    private void Start()
    {
        DescBox.text = sentences[0];
    }

    public void GoRight()
    {
        if (index != sentences.Length)
        {
            index++;
            DescBox.text = sentences[index];
            StopAllCoroutines();
            StartCoroutine(DisplayText(sentences[index]));
        }
        else
        {
            Debug.Log("Already maxed out can't go right!");
        }
    }

    public void GoLeft()
    {
        if (index != 0)
        {
            index--;
            DescBox.text = sentences[index];
            StopAllCoroutines();
            StartCoroutine(DisplayText(sentences[index]));

        }
        else
        {
            Debug.Log("Already maxed out can't go left!");

        }
    }

    IEnumerator DisplayText(string sentence)
    {
        DescBox.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            DescBox.text += letter;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
