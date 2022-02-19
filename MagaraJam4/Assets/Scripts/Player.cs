using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static float hiz = 5;
    private float hAbs;
    [SerializeField] UI_Inventory uiInventory;

    private Inventory inventory;

    void Start()
    {
        inventory = transform.GetComponent<Inventory>();
        uiInventory.SetInventory(inventory);
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



