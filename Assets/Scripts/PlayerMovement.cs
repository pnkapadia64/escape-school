using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        Logger.Instance.Log(" start player");
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ExitDoor")
        {
            Logger.Instance.Log(" Exit door ");
            MainController.Instance.onExit();
        }

        if (other.tag == "DeskA")
        {
            Logger.Instance.Log(" desk A ");
        }
        if (other.tag == "DeskB")
        {
            Logger.Instance.Log(" desk B ");
        }
        if (other.tag == "DeskC")
        {
            Logger.Instance.Log(" desk C ");
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
