using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("EscapeRoom");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
