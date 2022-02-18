using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuSahneDegistirme : MonoBehaviour
{

    public int sahneid;
    public int sahneid2;

     public void Baslat()
    {
        SceneManager.LoadScene(sahneid);
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene(sahneid2);
    }
    public void Cikis()
    {
        Application.Quit();
    }


}
