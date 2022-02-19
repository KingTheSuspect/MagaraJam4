using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParaSistemi : MonoBehaviour
{
    public TextMeshProUGUI parasayar;

    public static double para = 1.27;


    private void FixedUpdate()
    {
        parasayar.text = "$" + para;

    }
}
