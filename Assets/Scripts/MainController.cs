using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : Singleton<MainController>
{
    private bool isPlaying;
    private bool hasWon;
    private bool hasLost;

    void Start()
    {
        isPlaying = true;
        hasWon = false;
        hasLost = false;
    }

    void Update()
    {
        
    }

    public void onExit()
    {
        isPlaying = false;
        hasWon = true;
    }

}
