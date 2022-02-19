using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaatSistemi : MonoBehaviour
{
    public static float saat = 8, dakika= 30;

    public TextMeshProUGUI texts;

    private void FixedUpdate()
    {
        texts.text = ""+saat.ToString("00")+":"+dakika.ToString("00");
        dakika += 5 * Time.deltaTime;
        if (dakika > 59)
        {
            saat += 1;
            dakika = 0;
        }
        if (saat == 24)
        {
            saat = 0;
        }
        if (saat >= 2 && saat < 7)
        {
            GunSistemi.gun += 1;
            SaatSistemi.saat = 8;
            SaatSistemi.dakika = 30;
        }

    }
}
