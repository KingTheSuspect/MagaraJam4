using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsikSistemi : MonoBehaviour
{
    public GameObject isiklar;

    private void Update()
    {
        if (SaatSistemi.saat >= 18)
        {
            Baslat();
        }
        if (SaatSistemi.saat <= 17)
        {
            Kapat();
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
