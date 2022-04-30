using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiGameManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject inGameMenu;
    public GameObject stopMenu;
    public GameObject endGameMenu;
    public Animator anim;
    public void Awake()
    {
        PlayerController.movementSpeed = 0;
        PlayerController.horizontalSpeed = 0;

    }
    public void StartGame()
    {
        anim.SetBool("New Bool",true);
        PlayerController.movementSpeed = 5;
        PlayerController.horizontalSpeed = 5;
        Time.timeScale = 1;
        startMenu.SetActive(false);
        inGameMenu.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Settings()
    {

    }
    public void StopGame()
    {
        Time.timeScale = 0;
        inGameMenu.SetActive(false);
        stopMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        inGameMenu.SetActive(true);
        stopMenu.SetActive(false);
    }
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
        startMenu.SetActive(true);
        stopMenu.SetActive(false);
    }
    public void Restart()
    {
        stopMenu.SetActive(false);
        SceneManager.LoadScene(0);

    }
}
