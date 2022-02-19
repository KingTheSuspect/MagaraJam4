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
            Instantiate(umut, new Vector2(0, 0), new Quaternion(0, 0, 0, 0));
            Destroy(kart);
            Destroy(this.gameObject);
          
        }
    }
}
