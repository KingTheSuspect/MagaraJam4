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
                 hikaye.text = "Bugün oldukça soðuk bir gün, ýsýnman biraz zaman alacak gibi görünüyor. Bir süre sonra yanýna bir kedi yavrusu geldi o da üþümüþ görünüyor.";

             }
             else
             {*/
            switch (random)
            {
                default:
                case 1:
                    hikaye.text = "Tam yatmak üzereyken küçük bir çocuk sana doðru geldi ve yemen için bir parça ekmek verdi.";
                    YemekSistemi.yemek += 20;
                    break;
                case 2:
                    hikaye.text = "Yanýna kardeþ olduklarý her halinden belli iki çocuk geldi ve yatacak bir yerleri olmadýðýný söylediler. Hepinizin beraber uyumasý için yeterli yer yok. Ne yapacaksýn?";
                    break;
                case 3:
                    hikaye.text = "Bu gece pek yatamýyorsun, aklýna sürekli bir zamanlar yanýnda olabildiðin ailen geliyor. Bir yandan özlediðin bu zamanlar diðer yandan kabusun olmuþ durumda...";
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
                        hikaye.text = "Þehrin tamamen alakasýz bir yerinde, sokakta yürürken ayaðýn bir taþa takýldý ve burkuldu. Ayaðýný biraz daha zorladýn fakat daha fazla yürüyemiyorsun. Hiç bilmediðin bir yerde bu soðukta yatmak zorunda kaldýn.";
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
