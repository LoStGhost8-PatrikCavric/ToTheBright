using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausedMenuUI;
    [SerializeField] private bool isPaused = false;

    private void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (GameManager.instance.CanPauseAndGameUIBeActive)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isPaused = !isPaused;
            }

            if (isPaused)
            {
                if (!pausedMenuUI.activeInHierarchy)
                {
                    ActivateMenu();
                }
                
            }
            else
            {
                DeactivateMenu();
            }
        }
        
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0;
        pausedMenuUI.SetActive(true);
        AudioListener.pause = true;
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        pausedMenuUI.SetActive(false);
        isPaused = false;
        AudioListener.pause = false;
    }
}
