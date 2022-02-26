using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Konusma2 : MonoBehaviour
{
    public TextMeshProUGUI butontext1;
    public TextMeshProUGUI butontext2;
    public TextMeshProUGUI konusma;
    public Button buton1;
    public Button buton2;
    public AraGecis4 aragecis4;

    private void Start()
    {
        konusma.text = "Bap bup bap bap bap wiuw wiuv";
        butontext1.text = "...";
        butontext2.text = "...";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_0);
        buton2.onClick.AddListener(Durum_0_0);
    }

    public void Durum_0_0()
    {
        konusma.text = "Özgürlük heykelimi onarabilir misin?";
        butontext1.text = "hA?";
        butontext2.text = "Tamam";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(ChangeScene);
        buton2.onClick.AddListener(ChangeScene);
        
    }
    public void ChangeScene()
    {
        aragecis4.Basla();
    }



}
