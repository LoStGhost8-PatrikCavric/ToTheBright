using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLastLvl : NPCInteraction
{
    
    void Start()
    {
        Debug.Log("Hopefully");
        FragmentHolder = GameObject.Find("FragmentHolder");
    }


}
