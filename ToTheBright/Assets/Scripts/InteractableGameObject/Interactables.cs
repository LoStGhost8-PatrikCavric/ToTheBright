using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool isPlayerInRange;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerInRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerInRange = false;
    }
}
