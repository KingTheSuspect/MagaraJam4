using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Muzik : MonoBehaviour
{
    public Text volumeAmount;

    public Slider slider;

    private void Start()
    {
        LoadAudio();
    }

    public void SetAudio(float value)
    {

        AudioListener.volume = value;

        volumeAmount.text = ((int)(value * 100)).ToString();
    }
    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audiVolume", AudioListener.volume);
    }
    private void LoadAudio()
    {
        if(PlayerPrefs.HasKey("audioVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("audiVolume");
            slider.value = PlayerPrefs.GetFloat("audiVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.3f);
            AudioListener.volume = PlayerPrefs.GetFloat("audiVolume");
            slider.value = PlayerPrefs.GetFloat("audiVolume");
        }
        
    }
}
