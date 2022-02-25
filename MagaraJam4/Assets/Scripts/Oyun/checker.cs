using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checker : MonoBehaviour
{
    public Animator transition;
    public static bool karakter1 = false;
    public static bool karakter2 = false;
    public static bool karakter3 = false;
    public static bool karakter4 = false;
    public GameObject karater1;
    public GameObject karater2;
    public GameObject karater3;
    public GameObject karater4;
    private bool tek = true;

    void Update()
    {
        if (karakter1 == true)
        {
            Destroy(karater1);
        }
        if (karakter2 == true)
        {
            Destroy(karater2);
        }
        if (karakter3 == true)
        {
            Destroy(karater3);
        }
        if (karakter4 == true)
        {
            Destroy(karater4);
        }
        if (karakter1 == true && karakter2 == true && karakter3 == true && karakter4 == true && tek == true)
        {

            tek = false;
            StartCoroutine(LoadLevel());
        }
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(14);
    }
}
