using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class IsikSistemi : MonoBehaviour
{
    public GameObject isiklar;
    public Light2D lights;

    private void Update()
    {
        if (SaatSistemi.saat >= 18)
        {
            Baslat();
        }
        if (SaatSistemi.saat <= 17 && SaatSistemi.saat > 7)
        {
            Kapat();
        }
        if (SaatSistemi.saat >= 9 && SaatSistemi.saat < 12)
        {
            lights.intensity = 0.8f;
        }
        if (SaatSistemi.saat >= 12 && SaatSistemi.saat < 15)
        {
            lights.intensity = 1.5f;
        }
        if (SaatSistemi.saat >= 15 && SaatSistemi.saat < 18)
        {
            lights.intensity = 0.7f;
        }
        if (SaatSistemi.saat >= 18 && SaatSistemi.saat < 21)
        {
            lights.intensity = 0.5f;
        }
        if (SaatSistemi.saat >= 21 && SaatSistemi.saat < 24)
        {
            lights.intensity = 0.3f;
        }
    }

     void Kapat()
    { 
            isiklar.gameObject.SetActive(false);
    }
    void Baslat()
    {
            isiklar.gameObject.SetActive(true);
    }
}
