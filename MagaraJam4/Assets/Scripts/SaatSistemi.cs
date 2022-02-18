using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaatSistemi : MonoBehaviour
{
    public float saat, dakika;

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
    }
}
