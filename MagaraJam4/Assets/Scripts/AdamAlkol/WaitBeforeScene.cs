using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitBeforeScene : MonoBehaviour
{
    public Animator adam;
    public Animator fade;
    public AudioSource haraket;
    public AudioSource icme;

    private void Start()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(2);
        adam.Play("Drink");
        yield return new WaitForSeconds(2);
        fade.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(5);
    }
    public void hareketses()
    {
        haraket.Play();
    }
    public void icmeses()
    {
        icme.Play();
    }
}
