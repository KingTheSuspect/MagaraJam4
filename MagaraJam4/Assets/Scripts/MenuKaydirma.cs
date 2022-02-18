using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuKaydirma : MonoBehaviour,  IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource click;
    public int x1;
    public int y1;
    public int x2;
    public int y2;
    public GameObject kare;
    public RectTransform myRectTransform;
    public void OnPointerEnter(PointerEventData eventData)
    {
        click.Play();
        myRectTransform.localPosition = new Vector2(x1,y1);
        kare.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        myRectTransform.localPosition = new Vector2(x2, y2);
        kare.SetActive(false);
    }
}
