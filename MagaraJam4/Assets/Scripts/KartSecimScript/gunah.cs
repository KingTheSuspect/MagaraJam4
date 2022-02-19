using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunah : MonoBehaviour
{
    public GameObject kart;
    public GameObject iyilik;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "suc")
        {
            iyilik.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
