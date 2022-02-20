using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    public static float hiz = 5;
    private float hAbs;
    public UI_Inventory uiInventory;

    private Inventory inventory;
    public TextMeshProUGUI parasayar;

    public static double money = 3.27;

    void Start()
    {
        inventory = transform.GetComponent<Inventory>();
    }

    public Inventory GetInventory()
    {
        return inventory;
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        hAbs = Mathf.Abs(h);
        animator.SetFloat("Speed", hAbs);
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
        parasayar.text = "$" + money.ToString("0.00"); ;

    }



}



