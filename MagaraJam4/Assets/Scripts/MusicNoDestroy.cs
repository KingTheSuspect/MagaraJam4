using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicNoDestroy : MonoBehaviour
{
    static bool AudioBegin = false;
    public AudioSource audioSource;
    Scene something;
    void Awake()
    {
        if (!AudioBegin)
        {
            audioSource.Play();
            DontDestroyOnLoad(audioSource);
            AudioBegin = true;
          
        }
        
    }
    void Update()
    {
        something = SceneManager.GetActiveScene();
        if (something.buildIndex == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
