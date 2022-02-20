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
    private bool alindi = true;
    private bool tik = false;
    private BarinakBina barinak;

    void Start()
    {
        barinak = FindObjectOfType<BarinakBina>(true);
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
            Randoms();
            if (GunSistemi.gun == 1 && ilk == true)
            {
                hikaye.text = "Bugün oldukça soðuk bir gün, ýsýnman biraz zaman alacak gibi görünüyor. Bir süre sonra yanýna bir kedi yavrusu geldi o da üþümüþ görünüyor.";
                secenek1.SetActive(true);
                secenek2.SetActive(true);
                ilk = false;

            }
            if (deger == 1 && tik == false)
            {
                Time.timeScale = 1f;
                tik = true;
                hikaye.text = "Kedi yanýna yaklaþýk sana kendini sevdirdi\n Ýnsanlýk seviyen 10 yükseldi";
                InsanlikSistemi.insanlik += 10;
                StartCoroutine(LoadLevel());
            }
            if (deger == 2 && tik == false)
            {
                Time.timeScale = 1f;
                tik = true;
                hikaye.text = "Kedi baþka bir evsizin yanýna gitmeye çalýþýrken ezildi\n Ýnsanlýk seviyen 10 düþtü";
                InsanlikSistemi.insanlik -= 10;
                StartCoroutine(LoadLevel());

            }
            else if (GunSistemi.gun > 1 && alindi == false)
            {

                switch (random)
                {
                    default:
                    case 1:
                        hikaye.text = "Tam yatmak üzereyken küçük bir çocuk sana doðru geldi ve yemen için bir parça ekmek verdi.";
                        YemekSistemi.yemek += 20;
                        alindi = true;
                        break;
                    case 2:
                        hikaye.text = "Geçmini hatýrlamaya çalýþýyorsun ama olmuyor, koca bir boþluk gibi";
                        alindi = true;
                        break;
                    case 3:
                        hikaye.text = "Bu gece pek yatamýyorsun, aklýna sürekli bir zamanlar yanýnda olabildiðin ailen geliyor. Bir yandan özlediðin bu zamanlar diðer yandan kabusun olmuþ durumda...";
                        alindi = true;
                        break;


                }
            }
            if (SaatSistemi.disarda == true)
            {
                Randoms2();
                switch (random2)
                {
                    case 1:
                        hikaye.text = "Þehrin tamamen alakasýz bir yerinde, sokakta yürürken ayaðýn bir taþa takýldý ve burkuldu. Ayaðýný biraz daha zorladýn fakat daha fazla yürüyemiyorsun. Hiç bilmediðin bir yerde bu soðukta yatmak zorunda kaldýn.";
                        break;
                    default:
                        break;
                }
            }


        }
    }
    public void Devam()
    {

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
}

