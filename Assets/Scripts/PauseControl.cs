using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
    public void Continue()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
        Time.timeScale = 1;
    }

    public void Settings()
    {
        Application.LoadLevel("Settings");
        Time.timeScale = 1;
    }
    
}
