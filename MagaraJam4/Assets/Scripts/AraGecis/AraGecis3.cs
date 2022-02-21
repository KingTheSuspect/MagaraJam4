using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AraGecis3 : MonoBehaviour
{
    public int sahne;
    private int contin;

    public void GeriDon()
    {
        contin = PlayerPrefs.GetInt("Saved");

        if (contin != 0)
        {
            SceneManager.LoadScene(sahne);
        }
        else
        {
            return;
        }
       

    }
}
