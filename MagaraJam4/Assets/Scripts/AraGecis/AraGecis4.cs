using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AraGecis4 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transition;
    public float sure;
    public int scene;

    public void Basla()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(sure);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(sure);
        SceneManager.LoadScene(scene);
    }

}