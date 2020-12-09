using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
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
