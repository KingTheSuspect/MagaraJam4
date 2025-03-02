using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaatSistemi : MonoBehaviour
{
    public static float saat = 8, dakika= 30;

    public TextMeshProUGUI texts;
    public Animator animator;
    public static bool disarda = false;
    private bool ilk = true;
    public GameObject Gece;
    public static event EventHandler MarketYenile;
    public GameObject ilkgece;
    private bool some = false;
    private void FixedUpdate()
    {
        texts.text = ""+saat.ToString("00")+":"+dakika.ToString("00");
        dakika += 8 * Time.deltaTime;
        if (dakika > 59)
        {
            saat += 1;
            dakika = 0;
        }
        if (saat == 24)
        {
            saat = 0;
        }
        if (saat >= 2 && saat < 7 && ilk == true)
        {
            disarda = true;
            if (disarda == true && GunSistemi.gun == 1)
            {
                ilk = false;
                some = true;
                StartCoroutine(LoadLevel3());

            }
            if (some == false)
            {
                StartCoroutine(LoadLevel());
                ilk = false;
            }


        }

    }
    IEnumerator LoadLevel()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Start2");
        Gece.SetActive(true);
        yield return new WaitForSeconds(2);
        Time.timeScale = 0f;
    }
    IEnumerator LoadLevel3()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Start2");
        ilkgece.SetActive(true);
        yield return new WaitForSeconds(2);
        Time.timeScale = 0f;
    }
    IEnumerator LoadLevel2()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Start2");

        Gece.SetActive(false);
        GunSistemi.gun += 1;
        SaatSistemi.saat = 8;
        SaatSistemi.dakika = 30;
        ilk = true;
        MarketYenile?.Invoke(this, EventArgs.Empty);
    }
    public void Devam()
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadLevel2());
        
    }
}
