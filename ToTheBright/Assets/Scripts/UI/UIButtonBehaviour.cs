using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIButtonBehaviour : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void RetryLevel()
    {
        SceneManager.LoadScene(GameManager.instance.LastLevelPlayed);
        GameManager.instance.INSTANCEResetAllGameStats.ResetBeforeLoad();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");

        var a = new ResetAllGameStats();
        a.ResetBeforeLoad();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game!!");
    }
}
