using UnityEngine;
using System;

public class PuzzleA : Singleton<PuzzleA>
{
    public GameObject[] pieces;

    private float[] currentRotationOfPiece;

    private float[] randomRotations = new float[] { 90f, 180f, 270f };

    // Start is called before the first frame update
    void Start()
    {
        Logger.Instance.Log("A starts");
        try
        {
            currentRotationOfPiece = new float[pieces.Length];
            for (int i = 0; i < pieces.Length; i++)
            {
                GameObject piece = (GameObject)pieces.GetValue(i);
                float zRotation = randomRotations[UnityEngine.Random.Range(0, randomRotations.Length)];
                Logger.Instance.Log("random=" + i + zRotation);
                currentRotationOfPiece.SetValue(zRotation, i);
                piece.transform.Rotate(0, 0, zRotation);
            }
        
            Logger.Instance.Log("ro:"+currentRotationOfPiece[0]);
        }
        catch (Exception e)
        {
            Logger.Instance.Log("ro st err-"+ e);
        }
    }

    // Update is called once per frame
    void Update() {}

    public void RotatePiece(int pieceIndex)
    {
        try
        {
            pieces[pieceIndex].transform.Rotate(0, 0, 90f);   
            float newRotation = pieces[pieceIndex].transform.rotation.eulerAngles.z;

            Logger.Instance.Log("RP3 " + pieceIndex);

            currentRotationOfPiece.SetValue(newRotation, pieceIndex);
            Logger.Instance.Log("RP4");
            Logger.Instance.Log("rot=" + pieceIndex + newRotation + (newRotation == 0f));
            if (arePiecesCorrect())
            {
                Logger.Instance.Log("DONE!");
            }
        }
        catch (Exception e)
        {
            Logger.Instance.Log("RP E-" + e);
        }
    }

    private bool arePiecesCorrect()
    {
        bool correct = true;
        for (int i = 0; i < pieces.Length; i++)
        {
            GameObject piece = (GameObject)pieces.GetValue(i);
            correct = (int)(piece.transform.rotation.eulerAngles.z) == 0;
            if (!correct)
            {
                break;
            }
        }

        return correct;
    }
}
