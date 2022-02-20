using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaslangicScript : MonoBehaviour
{
    public Animator transition;

    public void Basla()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
