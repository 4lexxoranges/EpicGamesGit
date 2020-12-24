using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float timerStart = 60;
    public Text timerText;
    PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timerStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timerStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timerStart).ToString();

        
    }
}
