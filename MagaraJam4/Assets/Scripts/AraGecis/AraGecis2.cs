using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AraGecis2 : MonoBehaviour
{
    public Animator transition;
    public float sure;
    public float sure2;
    public int scene;
    public TextMeshProUGUI text;

    public void Start()
    {
        text.text = "Belki de Tanri'nin bizi avutma sekli, yaratma gücünü bahsetmesidir.";
        StartCoroutine(LoadLevel());
        
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(sure);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(sure2);
        text.text = "Oynadiginiz icin tesekkurler";
        transition.SetTrigger("Start2");
        yield return new WaitForSeconds(sure);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(sure);
        SceneManager.LoadScene(0);
    }
}
