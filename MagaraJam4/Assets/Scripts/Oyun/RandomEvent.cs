using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomEvent : MonoBehaviour
{
    private int random;
    private int random2;
    public TextMeshProUGUI hikaye;
    public GameObject devam;
    public GameObject secenek1;
    public GameObject secenek2;
    private int deger;
    private bool ilk = true;
    private bool alindi = false;
    private bool tik = false;
    private BarinakBina barinak;

    void Start()
    {
        barinak = FindObjectOfType<BarinakBina>(true);
        Randoms();
    }


    private void Randoms()
    {
        random = Random.Range(1, 4);
    }
    private void Randoms2()
    {
        random2 = Random.Range(1, 2);
    }

    public void Update()
    {
        if (BarinakBina.dinlen == true)
        {
           
            if (GunSistemi.gun == 1 && ilk == true)
            {
                hikaye.text = "Bug�n olduk�a so�uk bir g�n, �s�nman biraz zaman alacak gibi g�r�n�yor. Bir s�re sonra yan�na bir kedi geldi o da ���m�� g�r�n�yor.";
                secenek1.SetActive(true);
                secenek2.SetActive(true);
                ilk = false;

            }
            if (deger == 1 && tik == false)
            {
                Time.timeScale = 1f;
                tik = true;
                hikaye.text = "Kedi yan�na yakla��p sana kendini sevdirdi";
                InsanlikSistemi.insanlik += 10;
                secenek1.SetActive(false);
                secenek2.SetActive(false);
                StartCoroutine(LoadLevel());
            }
            if (deger == 2 && tik == false)
            {
                Time.timeScale = 1f;
                tik = true;
                hikaye.text = "Kedi ba�ka bir evsizin yan�na gitmeye �al���rken yeni gelen bir evsiz, kedinin �zerine bast�";
                InsanlikSistemi.insanlik -= 10;
                secenek1.SetActive(false);
                secenek2.SetActive(false);
                StartCoroutine(LoadLevel());

            }

            if (GunSistemi.gun > 1 && alindi == false)
            {
                
                switch (random)
                {
                    default:
                    case 1:
                        hikaye.text = "Tam yatmak �zereyken k���k bir �ocuk sana do�ru geldi ve yemen i�in bir par�a ekmek verdi.";
                        YemekSistemi.yemek += 20;
                        alindi = true;
                        devam.SetActive(true);
                        break;
                    case 2:
                        hikaye.text = "Ge�mini hat�rlamaya �al���yorsun ama olmuyor, koca bir bo�luk gibi";
                        alindi = true;
                        devam.SetActive(true);
                        break;
                    case 3:
                        hikaye.text = "Bu gece pek yatam�yorsun, akl�na s�rekli bir zamanlar yan�nda olabildi�in ailen geliyor. Bir yandan �zledi�in bu zamanlar di�er yandan kabusun olmu� durumda...";
                        alindi = true;
                        devam.SetActive(true);
                        break;


                }
            }



        }
        if (SaatSistemi.disarda == true && GunSistemi.gun == 1)
        {

        }
        else if (SaatSistemi.disarda == true)
        {
            Randoms2();
            switch (random2)
            {
                case 1:
                    hikaye.text = "�ehrin tamamen alakas�z bir yerinde, sokakta y�r�rken aya��n bir ta�a tak�ld� ve burkuldu. Aya��n� biraz daha zorlad�n fakat daha fazla y�r�yemiyorsun. Hi� bilmedi�in bir yerde bu so�ukta yatmak zorunda kald�n.";
                    devam.SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
    public void Devam()
    {
        Time.timeScale = 1f;
        barinak.Devam();
        devam.SetActive(false);

    }
    public void Secenek1()
    {
        deger = 1;
    }
    public void Secenek2()
    {
        deger = 2;
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(2);
        barinak.Devam();
    }
    IEnumerator LoadLevel2()
    {
        yield return new WaitForSeconds(5);
        alindi = false;
        Randoms();
    }
}

