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
            /* if (GunSistemi.gun == 1)
             {
                 hikaye.text = "Bug�n olduk�a so�uk bir g�n, �s�nman biraz zaman alacak gibi g�r�n�yor. Bir s�re sonra yan�na bir kedi yavrusu geldi o da ���m�� g�r�n�yor.";

             }
             else
             {*/
            switch (random)
            {
                default:
                case 1:
                    hikaye.text = "Tam yatmak �zereyken k���k bir �ocuk sana do�ru geldi ve yemen i�in bir par�a ekmek verdi.";
                    YemekSistemi.yemek += 20;
                    break;
                case 2:
                    hikaye.text = "Yan�na karde� olduklar� her halinden belli iki �ocuk geldi ve yatacak bir yerleri olmad���n� s�ylediler. Hepinizin beraber uyumas� i�in yeterli yer yok. Ne yapacaks�n?";
                    break;
                case 3:
                    hikaye.text = "Bu gece pek yatam�yorsun, akl�na s�rekli bir zamanlar yan�nda olabildi�in ailen geliyor. Bir yandan �zledi�in bu zamanlar di�er yandan kabusun olmu� durumda...";
                    break;

                    /*  }
                  }*/
            }
            if (SaatSistemi.disarda == true)
            {
                Randoms2();
                switch (random2)
                {
                    case 1:
                        hikaye.text = "�ehrin tamamen alakas�z bir yerinde, sokakta y�r�rken aya��n bir ta�a tak�ld� ve burkuldu. Aya��n� biraz daha zorlad�n fakat daha fazla y�r�yemiyorsun. Hi� bilmedi�in bir yerde bu so�ukta yatmak zorunda kald�n.";
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
