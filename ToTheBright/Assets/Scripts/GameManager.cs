using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject PauseUI;
    public ResetAllGameStats INSTANCEResetAllGameStats;
    public AudioSource myAudioSource;
    
    //public GameObject PauseUI;
    //public bool isPaused = false;

    public static GameManager instance;
    //public KeybindsManager keybinds;

    public DialogueManager dialogueManager;
    public Animator starAnim;

    private GameObject go;

    public int itemCounter;
    public int totalCounter;
    public bool CanPauseAndGameUIBeActive;
    public string LastLevelPlayed;

    public List<string> Inventory = new List<string>();



    //public Dictionary<string, KeyCode> dictionary = new Dictionary<string, KeyCode>();

    //public string LastLevel


    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            DestroyImmediate(gameObject);
        }
    }
    private void Start()
    {
        LastLevelPlayed = "Level01";
        totalCounter = 5;
        //gameUI = GetComponentInChildren<Canvas>().gameObject;
        INSTANCEResetAllGameStats = GetComponent<ResetAllGameStats>();
        myAudioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        CheckIfGameUIAndPauseUICanBeActive();
        if (CanPauseAndGameUIBeActive!=gameUI.activeSelf)
        {
            gameUI.SetActive(CanPauseAndGameUIBeActive);
        }
        if (CanBGMusicPlay())
        {
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }
           
        }else { myAudioSource.Stop(); }
    }
    

    public void UpdateTotal()
    {
        switch (LastLevelPlayed)
        {
            case "Level01":
                totalCounter = 4;
                break;
            case "Level02":
                totalCounter = 5;
                break;
            case "Level03":
                totalCounter = 4;
                break;
            case "Level04":
                totalCounter = 6;
                break;
            case "Level05":
                totalCounter = 4;
                break;
            default:
                totalCounter = 2;
                break;
        }
                //Debug.Log(totalCounter);
                gameUI.transform.Find("Total").GetComponent<Text>().text = "/" + totalCounter;
    }
    public void UpdateCounter()
    {
        // gameUI.transform.Find("Num").GetComponent<Text>().text = "x0" + itemCounter;
        gameUI.transform.Find("Num").GetComponent<Text>().text="x"+itemCounter;
    }
   
   
    public void CheckIfGameUIAndPauseUICanBeActive()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        if (activeScene == "MainMenu" || activeScene == "MainMenuSunVersion" || activeScene == "IntroCutscene" || activeScene == "OutroScene05"|| activeScene == "GameOver" )
        {
            CanPauseAndGameUIBeActive = false;
        }
        else { CanPauseAndGameUIBeActive=true; }
    }
   
    public bool CanBGMusicPlay()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        if (activeScene == "Level01" || activeScene == "Level02" || activeScene == "Level03" || activeScene == "Level04" || activeScene == "Level05")
        {
            return true;
        }
        return false;
        
    }
}
