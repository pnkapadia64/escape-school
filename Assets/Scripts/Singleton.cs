using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IMP
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance {
        get;
        private set;
    }

    public static bool IsInitialised
    {
        get { return Instance != null; }
    }
    protected virtual void Awake()
    {
        Instance = (T)this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void onDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }
}
