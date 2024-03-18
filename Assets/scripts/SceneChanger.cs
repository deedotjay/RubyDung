using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }

    public void LoadGame()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene("Third Person");
    }

    public void AdventureMode()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene("Rubylands");
    }

    public void ModeSelect()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene("ModeSelect");
    }
}

