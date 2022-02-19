using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merhamet : MonoBehaviour
{
    public GameObject kart;
    public GameObject hata;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "acýma")
        {
            hata.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
