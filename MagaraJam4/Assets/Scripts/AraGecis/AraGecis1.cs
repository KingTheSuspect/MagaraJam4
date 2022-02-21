using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AraGecis1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transition;
    public float sure;
    public int scene;
    private bool ilk;

    public void Start()
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