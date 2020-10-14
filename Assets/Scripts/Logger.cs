using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Logger : Singleton<Logger>
{
    public TextMeshProUGUI loggerText;

    void Start()
    {
        loggerText.text = "START";
    }

    public void Log(string msg)
    {
        if (msg.Length > 0)
        {
            loggerText.text += '\n' + msg;
        }
    }
}
