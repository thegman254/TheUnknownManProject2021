using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Credit to Brackeys. -> https://www.youtube.com/watch?v=_nRzoTzeyxU

public class DialogueManager : MonoBehaviour
{
  

  private Queue<string> sentences; // The queue used for displaying sentences
  public static int sentenceNumber = 0; // for reference in the event I needed the specific sentence for code execution.
  public Queue<string> Sentences // In the event I needed to reassign or get sentences elsewhere.
  {
    get => sentences;
    set => sentences = value;
  }

  private Queue<string> names; // The queue of names potentially used.

  public Queue<string> Names // queue for retrieving names if necessary.
  {
    get => names; 
  }


  public Text nameText; // The text that displays the names
  public Text dialogueText; // The text that displays the sentences.
  public float time; // How long each letter takes to appear.
  public bool hasTime = false; // Do the letters have a delay between each appearance?
  public bool DialogueJustFinished = false; // Check to see if the dialogue just ended this is used purely for scene transitioning.
  private int keyPressedCount = 0; // How many times has Z been pressed
  private int totalSentences; // How many sentences in total?
  public bool multiNames; // Are there multiple people or just one person speaking?



 public void nameSetup(Dialogue dialogue) // Puts the names in use for the scene into the names queue.
  {
    foreach (string name in dialogue.names)
    {
      names.Enqueue(name); 
    }
  }

 private void Awake()
 {
   names = new Queue<string>(); // Makes sure that names is set up before anything else so no weird errors happen on start.
 }

 void Start()
 {
   sentences = new Queue<string>(); // initialises the sentence queue.
   
    
   
  }
  

  private void Update()
  {
    
    if (Input.GetButtonDown("Action"))
    {
      keyPressedCount++; // Increments the key pressed count
    }
    
    
    
    if (Input.GetButtonDown("Action") && keyPressedCount > totalSentences) // Checks if the amount of times Z is pressed is as many as the sentences in the scene
    {
      DialogueJustFinished = EndDialogue(); // then ends the scene if evaluating to true;
    }
  }

  public void StartDialogue(Dialogue dialogue)
  {
  
    
    Debug.Log($"Starting conversation with {names.Peek()}"); // Test debug.log

    totalSentences = dialogue.sentences.Length-1; // The amount of sentences in the queue.
    sentences.Clear();

    if (dialogue.names[0].Length > 0 && dialogue.names != null) // Checks to see if the check is not empty
    {
      nameText.text = names.Peek(); // assigns the current item in the queue to the name
    }

    foreach (string sentence in dialogue.sentences)
    {
      sentences.Enqueue(sentence); // Loads in all the sentences
    }

 
    
    DisplayNextSentence(); // Displays a sentence.
  }

  public void DisplayNextSentence()
  {
    if (sentences.Count == 0) // checks if dialogue has 0 lines left
    {
      EndDialogue();  // if yes, end it.
      return;
    }

   
    else
    {
      if (names.Count >= 1)
      {
        if (multiNames) // Checks if there are multiple names
        {
          nameText.text = names.Dequeue(); // If yes, change the name to the Dequeued name upon update
        }

        else
        {
          nameText.text = names.Peek(); // If no, keep it the same.
        }

      }

      string sentence = sentences.Dequeue(); // Sets the sentence to the dequeued next element
      sentenceNumber++; // Increments the sentence you're on
      StopAllCoroutines();
      if (!hasTime)
      {
        StartCoroutine(TypeSentence(sentence)); // Does the nice typing effect with 0 delay
        // realistically this would be an option in the full game.
      }

      else
      {
        StartCoroutine(TypeSentence(sentence, time)); // What is generally used in this version of the game.
        // Dialogue waits 0.05 seconds before every letter is displayed.
      }
    }
  }

  IEnumerator TypeSentence(string Sentence, float time = 0f)
  {
    
    dialogueText.text = ""; // empty string to be assigned to
   
    if (hasTime) // the time based dialogue coroutine.
    {
      foreach (char letter in Sentence.ToCharArray()) // convert to character array as it's necessary...
      {

        dialogueText.text += letter; // Add to the string 
        yield return new WaitForSeconds(time); // Wait for 0.05 seconds
        // repeat.
      }
    }
    

    else
    {
      foreach (char letter in Sentence.ToCharArray()) // Same as above but with no delay.
      {

        dialogueText.text += letter;
        yield return null;
      }

    }
  }



  public bool EndDialogue()
  {
    if (sentences.Count == 0 && keyPressedCount > totalSentences) // checks if the player has gone through the dialogue.
    {
      Debug.Log("End of conversation."); // If yes, conversation ends.
      return true; // returns true to the DialogueJustFinished bool
    }

    else
    {
      return false; 
      // Others returns false to same bool
    }

    



  }


}
