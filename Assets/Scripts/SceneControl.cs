using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void Start()
    {
        
    }

    public void Update()
    {
        
    }
    public void SceneManager(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
