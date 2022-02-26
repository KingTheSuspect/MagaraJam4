using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunlukYokEdici : MonoBehaviour
{
    public GameObject karakterler;
    public GameObject afisler;
    private bool kilit1 = false;
    private bool kilit2 = false;
    public GameObject kiz;
    

    private void Update()
    {
        if (GunSistemi.gun >= 2 && !kilit1)
        {
            kiz.SetActive(true);
            afisler.SetActive(true);
            kilit1 = true;
            
        }
        if (GunSistemi.gun >= 3 && !kilit2)
        {
            karakterler.SetActive(true);
            kilit2 = true;
        }
    }
}
