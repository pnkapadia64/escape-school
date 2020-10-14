using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleA : Singleton<PuzzleA>
{
    public GameObject[] pieces;

    private int[] currentRotationOfPiece;

    private int[] randomRotations = new int[] { 90, 180, 270 };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pieces.Length; i++) {
            GameObject piece = pieces[i];
            int zRotation = Random.Range(0, randomRotations.Length);
            currentRotationOfPiece[i] = zRotation;
            piece.transform.Rotate(0, 0, zRotation);
        }
        Logger.Instance.Log("ro:"+currentRotationOfPiece.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotatePiece(int pieceIndex)
    {
        pieces[pieceIndex].transform.Rotate(0, 0, 90f);
        int newRotation = (int)(pieces[pieceIndex].transform.rotation.eulerAngles.z);
        currentRotationOfPiece[pieceIndex] = newRotation;

        if (arePiecesCorrect())
        {
            Logger.Instance.Log("DONE!");
        }
    }

    private bool arePiecesCorrect()
    {
        bool correct = true;
        for (int i = 0; i < pieces.Length; i++)
        {
            GameObject piece = pieces[i];
            correct = (int)(piece.transform.rotation.eulerAngles.z) == 0;
            if (!correct)
            {
                break;
            }
        }

        return correct;
    }
}
