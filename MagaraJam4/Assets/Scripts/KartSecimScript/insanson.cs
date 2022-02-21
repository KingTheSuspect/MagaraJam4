using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class insanson : MonoBehaviour
{
    public Animator transition;
    public int sahne;
    private int contin;

    public void GeriDon()
    {
        contin = PlayerPrefs.GetInt("Saved");

        if (contin != 0)
        {
            StartCoroutine(LoadLevel());
        }
        else
        {
            return;
        }


    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sahne);
        checker.karakter4 = true;
    }
}
