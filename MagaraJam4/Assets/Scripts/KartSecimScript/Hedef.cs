using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hedef : MonoBehaviour
{
    public GameObject kart;
    public GameObject umut;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "amac")
        {
            umut.SetActive(true);
            Destroy(kart);
            Destroy(this.gameObject);
          
        }
    }
}
