using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float hiz;
    private float hAbs;

    void Start()
    {

    }


    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");

        hAbs = Mathf.Abs(h);

        if (h > 0.1f)
        {
            transform.localScale = new Vector2(1, 1);
            transform.Translate(h * hiz * Time.deltaTime, 0, 0);

        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(h * hiz * Time.deltaTime, 0, 0);
        }


    }



}



