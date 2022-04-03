using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHeart : MonoBehaviour
{
    public Sprite newButtonImage;
    public Button button;

    public void ChangeButtonImage()
    {
        button.image.sprite = newButtonImage;
    }
}
