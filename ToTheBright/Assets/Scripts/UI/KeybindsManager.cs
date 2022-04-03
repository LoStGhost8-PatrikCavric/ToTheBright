using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeybindsManager : MonoBehaviour
{
    public Dictionary<string, KeyCode> dictionary = new Dictionary<string, KeyCode>();

    public Text left, right, jump, dialogue;

    GameObject CurrentKey;

    // Start is called before the first frame update
    void Awake()
    {
        dictionary.Add("MoveLeft", KeyCode.A);
        dictionary.Add("MoveRight", KeyCode.D);
        dictionary.Add("Jump", KeyCode.Space);
        dictionary.Add("Dialogue", KeyCode.E);

        //left.text = dictionary["MoveLeft"].ToString();
        //right.text = dictionary["MoveRight"].ToString();
        //jump.text = dictionary["Jump"].ToString();
        //dialogue.text = dictionary["Dialogue"].ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(dictionary["MoveLeft"]))
        {
            Debug.Log("MoveLeft has been pressed!");
        }

        if (Input.GetKeyDown(dictionary["MoveRight"]))
        {
            Debug.Log("MoveRight has been pressed!");
        }

        if (Input.GetKeyDown(dictionary["Jump"]))
        {
            Debug.Log("Jump has been pressed!");
        }

        if (Input.GetKeyDown(dictionary["Dialogue"]))
        {
            Debug.Log("Dialogue has been pressed!");
        }
    }

    public void OnGUI()
    {
        if (CurrentKey != null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                dictionary[CurrentKey.name] = e.keyCode;
                CurrentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                CurrentKey = null;
            }
        }
    }

    public void GetKey(GameObject clicked)
    {
        CurrentKey = clicked;
    }
}
