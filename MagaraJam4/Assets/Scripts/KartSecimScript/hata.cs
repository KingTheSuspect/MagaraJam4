using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hata : MonoBehaviour
{
    public GameObject kart;
    public GameObject gercek;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "iyilik")
        {
            gercek.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
