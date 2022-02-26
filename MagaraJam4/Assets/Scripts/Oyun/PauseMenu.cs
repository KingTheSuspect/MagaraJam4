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
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Player.playerInstance.inventoryUI.SetActive(false);

        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Player.playerInstance.uiInventory.RefreshItems(Player.playerInstance.GetInventory());
        Player.playerInstance.inventoryUI.SetActive(true);
        if (sayac == 0)
        {
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