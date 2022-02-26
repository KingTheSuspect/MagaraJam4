using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Konusma3 : MonoBehaviour
{
    public TextMeshProUGUI butontext1;
    public TextMeshProUGUI butontext2;
    public TextMeshProUGUI konusma;
    public Button buton1;
    public Button buton2;
    public AraGecis4 aragecis4;

    private void Start()
    {
        konusma.text = "Kimsin?";
        butontext1.text = "Bilmem";
        butontext2.text = "Kiz kardeþinle konuþtuk";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_1);
        buton2.onClick.AddListener(Durum_0_2);
    }

    public void Durum_0_1()
    {
        konusma.text = "Lütfen benden uzaklaþ";
        butontext1.text = "Þaka, beni kardeþin gönderdi";
        butontext2.text = "Kandirdim, kardesinle konuþtum";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_2);
        buton2.onClick.AddListener(Durum_0_2);
        
    }
    public void Durum_0_2()
    {
        konusma.text = "Babam yillar önce evden çikarken bunu bana verdi fakat yirtildi, uzerinde bir sey yaziyor";
        butontext1.text = "Tamam";
        butontext2.text = "Yardim edebilirim";
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
