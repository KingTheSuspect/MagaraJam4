using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YemekSistemi : MonoBehaviour
{
    public TextMeshProUGUI yemeksayar;

    public static int yemek = 65;
    private int random;
    private float saat;

    private void Randomsayi()
    {
        random = Random.Range(5, 15);
        
    }

    private void FixedUpdate()
    {
        yemeksayar.text = "%" + yemek;
        saat += Time.deltaTime;
        if (saat >= 10)
        {
            Randomsayi();
            yemek -= random;
            saat = 0;
        }
        if (yemek <= 0)
        {
            yemek = 0;
            Player.hiz = 2;
        }
        else
        {
            Player.hiz = 5;
        }


    }
    public void SetYemekSayar()
    {
        yemeksayar.text = "%" + yemek;
    }


}