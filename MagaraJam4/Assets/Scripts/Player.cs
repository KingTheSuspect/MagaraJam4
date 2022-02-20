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
    public float itemGetDistance = 5f;
    bool onTheGround = false;
    float yHiz = 0;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float jumpDownSpeed = 15f;
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
        onTheGround = Physics2D.Raycast(transform.position, Vector3.down, 1.5f,LayerMask.GetMask("Ground"));
        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            onTheGround = false;
            yHiz += jumpSpeed;
        }
        if (onTheGround)
            yHiz = 0;
        hAbs = Mathf.Abs(h);
        animator.SetFloat("Speed", hAbs);
        if (h > 0.1f)
        {
            transform.localScale = new Vector2(1, 1);
            transform.Translate(h * hiz * Time.deltaTime, yHiz * hiz * Time.deltaTime, 0);

        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(h * hiz * Time.deltaTime, yHiz * hiz*Time.deltaTime, 0);
        }
        if(h ==0)
        {
            transform.Translate(h * hiz * Time.deltaTime, yHiz * hiz * Time.deltaTime, 0);
        }
        parasayar.text = "$" + money.ToString("0.00");

        if(!onTheGround)
            yHiz -= Time.deltaTime* jumpDownSpeed;
    }



}



