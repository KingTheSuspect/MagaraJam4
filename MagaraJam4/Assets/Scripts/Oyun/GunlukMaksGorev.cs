using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunlukMaksGorev : MonoBehaviour
{
    public static int maksgorev = 0;
    public static int durum = 0;
    public static bool karakterlock = false;
    private bool kilit2;
    private bool kilit3;
    private bool kilit4;

    private void Update()
    {
        if (kilit2 == false)
        {
            switch (checker.karakter2)
            {
                case true:
                    durum++;
                    kilit2 = true;
                    break;
                default:
                    break;

            }
        }
        if (kilit3 == false)
        {
            switch (checker.karakter3)
            {
                case true:
                    durum++;
                    kilit3 = true;
                    break;
                default:
                    break;
            }
        }
        if (kilit4 == false)
        {
            switch (checker.karakter4)
            {
                case true:
                    durum++;
                    kilit4 = true;
                    break;
                default:
                    break;
            }
        }
        if (durum == maksgorev)
        {
            karakterlock = true;
        }
        else
        {
            karakterlock = false;
        }
        maksgorev = GunSistemi.gun - 2;


    }
}
