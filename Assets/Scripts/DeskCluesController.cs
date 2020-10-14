using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskCluesController : Singleton<DeskCluesController>
{

    public Transform[] deskPoints;
    public GameObject[] deskClues;

    void Start()
    {
        int clueCount = deskClues.Length;

        for(int i = 0; i < clueCount; i++)
        {
            int pointIndex = Mathf.FloorToInt(Random.Range(0f, deskPoints.Length - 0.1f));
            Logger.Instance.Log("clue at:" + pointIndex);
            deskClues[i].transform.position = deskPoints[pointIndex].position;
        }
    }

    void Update()
    {
        
    }
}
