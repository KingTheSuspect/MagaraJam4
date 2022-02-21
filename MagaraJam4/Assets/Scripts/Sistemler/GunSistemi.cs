using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunSistemi : MonoBehaviour
{
    public TextMeshProUGUI gunsayar;

    public static int gun = 2;



    private void FixedUpdate()
    {
        gunsayar.text = "Gun " + gun;


    }
}
