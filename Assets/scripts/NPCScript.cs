using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{

    public GameObject npc_text_bg;

    void Start()
    {
        npc_text_bg.SetActive(false);
    }


    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider collider)
    {
        npc_text_bg.SetActive(true);
    }

    void OnTriggerExit(Collider collider)
    {
        npc_text_bg.SetActive(false);
    }
}
