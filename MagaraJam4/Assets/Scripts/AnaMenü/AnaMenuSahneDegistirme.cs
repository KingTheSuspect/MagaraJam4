using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuSahneDegistirme : MonoBehaviour
{
    public Animator transition;
    public int oyna;
    public int ayarlar;
    public float sure;

    public void Baslat()
    {
        StartCoroutine(LoadLevel());
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene(ayarlar);
    }
    public void Cikis()
    {
        Application.Quit();
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(sure);
        SceneManager.LoadScene(oyna);
    }

}
