using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject pauseMenu;
    public static UImanager instance { set; get; }

    private void Start()
    {
        instance = this;

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);


    }
    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverMenu.SetActive(true);
    }
    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
    public void pauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);

    }
}