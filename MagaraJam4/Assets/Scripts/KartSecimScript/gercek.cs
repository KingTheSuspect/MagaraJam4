using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gercek : MonoBehaviour
{
    public GameObject kart;
    public GameObject insan;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "hayal")
        {
            insan.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
