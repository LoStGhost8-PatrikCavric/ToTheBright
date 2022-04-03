using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitIntro : MonoBehaviour
{
    public float waitFor = 10f;

    private void Start()
    {
        StartCoroutine(Wait());
    }
    
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitFor);
        SceneManager.LoadScene("MainMenu");
    }
}
