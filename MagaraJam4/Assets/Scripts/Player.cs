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
    [SerializeField] TMPro.TMP_Text dialogueText;
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
            transform.Translate(h * hiz * Time.deltaTime, hiz * Time.deltaTime, 0);

        }
        if (h < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
            transform.Translate(h * hiz * Time.deltaTime, hiz*Time.deltaTime, 0);
        }
        parasayar.text = "$" + money.ToString("0.00");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueText.color = new Color(dialogueText.color.r, dialogueText.color.g, dialogueText.color.b, 1f);
        if (collision.gameObject.layer == LayerMask.NameToLayer("Posters"))
        {
            dialogueText.text = collision.gameObject.GetComponent<PosterController>().GetText();
            dialogueText.transform.parent.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Posters"))
        {
            StartCoroutine(TextFadeOut());
        }
    }
    IEnumerator TextFadeOut()
    {
        while (dialogueText.color.a > 0)
        {
            Color tempColor = dialogueText.color;
            dialogueText.color = new Color(tempColor.r,tempColor.g,tempColor.b,tempColor.a-.1f);
            yield return new WaitForSeconds(.05f);
        }
        dialogueText.transform.parent.gameObject.SetActive(false);

    }

}



