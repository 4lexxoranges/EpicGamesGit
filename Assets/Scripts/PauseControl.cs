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
    public void PauseOn()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }
    public void PauseOff()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }
    public void Continue()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void Menu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Settings()
    {
        Application.LoadLevel("Settings");
    }
}
