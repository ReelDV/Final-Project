using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReQuit : MonoBehaviour
{
    public void GameQuit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Final Project");
    }
}
