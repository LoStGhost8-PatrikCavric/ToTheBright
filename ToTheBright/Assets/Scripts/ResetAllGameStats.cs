using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAllGameStats : MonoBehaviour
{
    public void ResetBeforeLoad()
    {
        
        GameManager.instance.itemCounter = 0;
        GameManager.instance.UpdateCounter();

    }
    public void ResetAfterLoad()
    {
        GameManager.instance.LastLevelPlayed = SceneManager.GetActiveScene().name;
        GameManager.instance.gameObject.GetComponent<GameUIImageChanger>().CheckAndUpdate();
       
    }
}
