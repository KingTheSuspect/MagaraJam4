using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Konusma4 : MonoBehaviour
{
    public TextMeshProUGUI butontext1;
    public TextMeshProUGUI butontext2;
    public TextMeshProUGUI konusma;
    public Button buton1;
    public Button buton2;
    public AraGecis4 aragecis4;

    private void Start()
    {
        konusma.text = "Sana þimdi bazi kartlar verecegim";
        butontext1.text = "Ne yapacagim?";
        butontext2.text = "Peki";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_0);
        buton2.onClick.AddListener(Durum_0_0);
    }

    public void Durum_0_0()
    {
        konusma.text = "Kartlari en yakin eþ anlamli veya zit olanlari eþleþtireceksin";
        butontext1.text = "Sonra?";
        butontext2.text = "Tamam";
        buton1.onClick.RemoveAllListeners();
        buton2.onClick.RemoveAllListeners();
        buton1.onClick.AddListener(Durum_0_1);
        buton2.onClick.AddListener(ChangeScene);
        
    }
    public void Durum_0_1()
    {
        konusma.text = "En sonda karþina çikacak kartin üzerinde gizli bir mesaj var";
        butontext1.text = "...";
        butontext2.text = "...";
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
