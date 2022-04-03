using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    // HOME BUTTON
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // EXIT BUTTON
    public void Exit()
    {
        Application.Quit();
    }
    // START GAME
    public void Play()
    {

        SceneManager.LoadScene("Level01");
        GameManager.instance.INSTANCEResetAllGameStats.ResetBeforeLoad();
        
    }
}
