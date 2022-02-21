using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eventdizi : MonoBehaviour
{
    public Animator fade;
    int yerlestirilen_parca = 0;
    int toplam_puzzle = 4;
    public void sayi_artir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplam_puzzle)
        {
            StartCoroutine(LoadLevel());
        }
    }
    IEnumerator LoadLevel()
    {
        fade.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(13);
        checker.karakter2 = true;
        checker.karakter3 = true;
    }
}
