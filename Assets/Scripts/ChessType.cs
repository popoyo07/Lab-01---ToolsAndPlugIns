using UnityEngine;

public class ChessType : MonoBehaviour
{
    public enum TypeOfChess
    {
        King,
        Queen,
        Bishop,
        Pawn,
        Rook,
        Knights
    }

    public TypeOfChess CurrentChess;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (CurrentChess)
        {
            case TypeOfChess.King:
                break;
            case TypeOfChess.Queen:
                break;
            case TypeOfChess.Bishop: 
                break;
            case TypeOfChess.Pawn: 
                break;
            case TypeOfChess.Rook: 
                break;
            case TypeOfChess.Knights: 
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
