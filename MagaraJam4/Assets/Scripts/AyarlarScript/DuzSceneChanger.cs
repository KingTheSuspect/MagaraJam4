using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DuzSceneChanger : MonoBehaviour
{
    public int sahne1;
    public int sahne2;
    public void SahneButon()
    {
        SceneManager.LoadScene(sahne1);
    }
    public void Sahne2Buton()
    {
        SceneManager.LoadScene(sahne2);
    }
}
