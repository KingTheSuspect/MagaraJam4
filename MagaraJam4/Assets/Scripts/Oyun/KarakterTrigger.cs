using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterTrigger : MonoBehaviour
{
    private bool triggered;
    public int scene;
    public Animator transition;
    private int currentscene;
    public GameObject uyari;
    IEnumerator LoadLevel()
        
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        triggered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
    private void Update()
    {
        if (GunlukMaksGorev.karakterlock == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && triggered == true)
            {
                StartCoroutine(LoadLevel());
                currentscene = SceneManager.GetActiveScene().buildIndex;
                PlayerPrefs.SetInt("Saved", currentscene);
            }
        }
        if (GunlukMaksGorev.karakterlock == true && triggered && Input.GetKeyDown(KeyCode.E))
        {
            uyari.gameObject.SetActive(true);
        }
        if (triggered == false)
        {
            uyari.gameObject.SetActive(false);
        }

    }
}
