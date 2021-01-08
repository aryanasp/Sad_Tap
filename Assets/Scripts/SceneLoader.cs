using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //config
    [SerializeField]
    private float delayForSeconds = 2f;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game Screen");
        FindObjectOfType<GameManager>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
