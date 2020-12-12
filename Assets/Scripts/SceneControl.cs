using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void SceneManager(string name)
    {
        Application.LoadLevel(name);
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Game");
    }

    public void Menu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}



