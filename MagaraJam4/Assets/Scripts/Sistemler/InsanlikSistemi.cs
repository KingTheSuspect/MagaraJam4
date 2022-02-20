using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InsanlikSistemi : MonoBehaviour
{
    public TextMeshProUGUI insanliksayar;

    public static int insanlik = 50;

    private void FixedUpdate()
    {
        insanliksayar.text = "%" + insanlik;

    }
}
