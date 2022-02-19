using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umut : MonoBehaviour
{
    public GameObject kart;
    public GameObject hayal;
    void Start()
    {

    }


    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "huzur")
        {
            hayal.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);

        }
    }
}
