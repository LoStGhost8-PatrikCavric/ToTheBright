using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverButton2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform Button;

    void Start()
    {
        Button.GetComponent<Animator>().Play("HoverOff2");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("HoverOn2");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Button.GetComponent<Animator>().Play("HoverOff2");
    }
}
