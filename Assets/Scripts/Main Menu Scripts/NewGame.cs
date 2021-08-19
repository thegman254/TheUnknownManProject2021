using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public KarmaSystem reset;
    
    public void NewGameFunc()
    {
        StartCoroutine(NewGameStart());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NewGameStart()
    {
        reset.karmaValue = 0;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("SampleScene");
    }
}
