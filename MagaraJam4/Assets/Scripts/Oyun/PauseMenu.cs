using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private int sayac = 0;
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    [SerializeField] UI_Inventory pauseMenuInventory;
    Inventory playerInventory = null;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if(playerInventory == null)
        {
            playerInventory = FindObjectOfType<Player>().GetInventory();
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        if (sayac == 0)
        {
            pauseMenuInventory.RefreshItems(playerInventory);
            sayac++;
        }
    }

    public void LoadMenu()

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}