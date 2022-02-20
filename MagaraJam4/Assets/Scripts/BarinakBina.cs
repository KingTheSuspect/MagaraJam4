using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarinakBina : MonoBehaviour
{
    public Animator transition;
    private bool triggered;
    public static bool GameIsPaused = false;
    public GameObject hata;
    public GameObject hata2;
    public static bool dinlen;

    public GameObject Gece;
    public GameObject Barinak;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered== true)
        {
            Time.timeScale = 0f;
            Barinak.SetActive(true);
        }
    }
    public void Dinlen()
    {
        if (SaatSistemi.saat >= 22 && SaatSistemi.dakika >= 0)
        {
            hata.SetActive(true);
        }
        else if (SaatSistemi.saat < 18)
        {
            hata2.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            dinlen = true;
            StartCoroutine(LoadLevel());
            Barinak.SetActive(false);

        }

    }
    public void Ayril()
    {
        Time.timeScale = 1f;
        Barinak.SetActive(false);
        hata.SetActive(false);
        hata2.SetActive(false);


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
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        transition.SetTrigger("Start2");
        Gece.SetActive(true);
        yield return new WaitForSeconds(2);
        Time.timeScale = 0f;
    }
    public void Devam()
    {
        StartCoroutine(LoadLevel2());
    }
    IEnumerator LoadLevel2()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        transition.SetTrigger("Start2");
        GunSistemi.gun += 1;
        SaatSistemi.saat = 8;
        SaatSistemi.dakika = 30;
        hata.SetActive(false);
        hata2.SetActive(false);
        Gece.SetActive(false);
        dinlen = false;

    }
}
