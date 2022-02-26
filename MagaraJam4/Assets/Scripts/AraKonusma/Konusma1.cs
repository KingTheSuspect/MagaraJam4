using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Konusma1 : MonoBehaviour
{
    public TextMeshProUGUI butontext1;
    public TextMeshProUGUI butontext2;
    public TextMeshProUGUI konusma;
    public Button buton1;
    public Button buton2;
    public AraGecis4 aragecis4;

    private void Start()
    {
        konusma.text = "Bana yardimci olabilir misin?";
        butontext1.text = "Evet";
        butontext2.text = "Tamam";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_0);
        buton2.onClick.AddListener(Durum_0_0);
    }

    public void Durum_0_0()
    {
        konusma.text = "Babam her gün eve alkollu bir sekilde gelip annemi dövüyordu.\n Bir keresinde kardeþim aralarina girmeye çaliþti fakat daha da kötü sonuçlandi";
        butontext1.text = "Anladim, ne yapabilirim?";
        butontext2.text = "Nasýl yardimci olabilirim?";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_1_0);
        buton2.onClick.AddListener(Durum_1_0);
        
    }
    public void Durum_1_0()
    {
        konusma.text = "Kardeþim sana söyleyecek";
        butontext1.text = "Kardeþini nereden bulacagim?";
        butontext2.text = "Ne zaman?";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(ChangeScene);
        buton2.onClick.AddListener(ChangeScene);

    }
    public void ChangeScene()
    {
        checker.karakter1 = true;
        aragecis4.Basla();
    }



}
