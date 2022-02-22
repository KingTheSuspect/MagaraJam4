using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transition;
    public float sure;
    public int scene;


    public void FadeTrans()
    {
        transition.SetTrigger("Start");
    }

    public void NextLoad()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(sure);
        transition.SetTrigger("Start");
    }

}