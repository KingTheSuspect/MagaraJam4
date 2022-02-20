using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MutlulukSistemi : MonoBehaviour
{
    public TextMeshProUGUI mutluluksayar;

    public static int mutluluk = 65;
    private int random;
    private float saat;
    public Animator animator;
    public GameObject dead;
    private bool ilk = true;
    public SpriteRenderer sprite;

    private void Randomsayi()
    {
        random = Random.Range(2, 16);

    }

    private void FixedUpdate()
    {
        mutluluksayar.text = "%" + mutluluk;
        saat += Time.deltaTime;
        if (saat >= 18)
        {
            Randomsayi();
            mutluluk -= random;
            saat = 0;
        }
        if (mutluluk <= 0 && ilk == true)
        {
            ilk = false;
            mutluluk = 0;
            StartCoroutine(LoadLevel());

        }
        if (mutluluk >= 80 && mutluluk <= 100)
        {
            
            sprite.color = (Color)(new Color32(21, 19, 21, 150));
        }
        if (mutluluk >= 60 && mutluluk < 80)
        {
            sprite.color = (Color)(new Color32(21, 19, 21, 170));
        }
        if (mutluluk >= 40 && mutluluk < 60)
        {
            sprite.color = (Color)(new Color32(21, 19, 21, 190));
        }
        if (mutluluk >= 20 && mutluluk < 40)
        {
            sprite.color = (Color)(new Color32(21, 19, 21, 210));
        }
        if (mutluluk >= 1 && mutluluk < 20)
        {
            sprite.color =  (Color)(new Color32(21, 19, 21, 230));
        }

        /* if (yemek <= 0)
         {
             yemek = 0;
             Player.hiz = 2;
         }
         else
         {
             Player.hiz = 4;
         }*/


    }
    IEnumerator LoadLevel()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Start2");
        dead.SetActive(true);
    }
    public void SetMutlulukSayar()
    {
        mutluluksayar.text = "%" + mutluluk;
    }


}
