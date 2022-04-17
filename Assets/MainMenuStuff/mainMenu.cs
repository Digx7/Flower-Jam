using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string name;
    public void PlayGame()
    {
        Debug.Log("Should have switched");
        SceneManager.LoadScene(name);
    }
    public void QuitGame()
    {
        Debug.Log("quit :D");
        Application.Quit();
    }
}
