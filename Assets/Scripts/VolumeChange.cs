using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Text VolumeText;
    private AudioSource VolumeToChange;
    public Slider VolumeSlider;
    void Start()
    {
        VolumeToChange = GetComponent<AudioSource>();
        // VolumeSlider = FindObjectOfType<Slider>();
        // VolumeText = GameObject.Find("VolumeText").GetComponent<Text>();
        // Debug.Log($"{VolumeSlider.name}, {VolumeText.name}, {VolumeToChange.name}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume()
    {
       
        VolumeToChange.volume = Mathf.Clamp01(VolumeSlider.value / 100);
        Debug.Log(Mathf.Clamp01(VolumeSlider.value / 100));
        VolumeText.text = "Volume: " + VolumeSlider.value + "%"; 

    }
}
