using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControl : MonoBehaviour
{
    public GameObject buttonStart;
    public GameObject pausePanel;
    public GameObject image;
    public GameObject image2;
    public GameObject mainMenu;
    public GameObject menu;
    public GameObject menu2;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame

    void Update()
    {

    }
    public void GoToMainMenu()
    {
        SceneTransition.SwitchToScene("MainMenu");
        buttonStart.SetActive(false);
    }

    public void SceneManager(string name)
    {

        Application.LoadLevel(name);
    }

    public void MenuOn()
    {
        mainMenu.SetActive(true);
    }
    public void MenuOff()
    {
        mainMenu.SetActive(false);
    }

    public void Players()
    {
        image2.SetActive(false);
        image.SetActive(true);
        menu.SetActive(true);
        menu2.SetActive(false);
    }

    public void Settings()
    {
        image.SetActive(false);
        image2.SetActive(true);
        menu.SetActive(false);
        menu2.SetActive(true);
    }

    public void Restart()
    {
        Application.LoadLevel("Floor is lava");
    }
    public void Equit()
    {
        Application.Quit();
    }
}



