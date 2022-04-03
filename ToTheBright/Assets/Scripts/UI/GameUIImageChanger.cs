using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum itemImage
{
    Heart,
    Clock,
    MusicNote,
    Page,
    Gamepad,
    none
}

public class GameUIImageChanger : MonoBehaviour
{
    public List<Sprite> itemLogos;
    public Image Item;
    //public int itemNum;

    public itemImage itemImage;
    
    
    void Start()
    {
        CheckAndUpdate();
    }

    

    public void CheckAndUpdate()
    {
        switch (GameManager.instance.LastLevelPlayed)
        {
            case "Level01":
                itemImage = itemImage.Heart;
                break;
            case "Level02":
                itemImage = itemImage.Clock;
                break;
            case "Level03":
                itemImage = itemImage.MusicNote;
                break;
            case "Level04":
                itemImage = itemImage.Page;
                break;
            case "Level05":
                itemImage = itemImage.Gamepad;
                break;
            default:
                itemImage = itemImage.none;
                break;
        }
        Item.sprite = itemLogos[((int)itemImage)];
    }
}
