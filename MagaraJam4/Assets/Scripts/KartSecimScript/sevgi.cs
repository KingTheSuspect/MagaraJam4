using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sevgi : MonoBehaviour
{
    public GameObject kart;
    public GameObject huzur;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ask")
        {
            huzur.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
