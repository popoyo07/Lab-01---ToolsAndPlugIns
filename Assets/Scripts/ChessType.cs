using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.U2D;

public class ChessType : MonoBehaviour
{
    public int range = 1;

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

    void OnDrawGizmosSelected()
    {
    Gizmos.color = Color.yellow;

        switch (CurrentChess)
        {
            case TypeOfChess.King:
                Gizmos.DrawLine(transform.position, transform.position + Vector3.left * 1);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.right * 1);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.up * 1);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1);
                Gizmos.DrawRay(transform.position, new Vector3(1, 1, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-1, -1, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-1, 1, 0));
                Gizmos.DrawRay(transform.position, new Vector3(1, -1, 0));
                break;
            case TypeOfChess.Queen:
                Gizmos.DrawLine(transform.position, transform.position + Vector3.left * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.right * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.up * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.down * range);
                Gizmos.DrawRay(transform.position, new Vector3(range, range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-range, -range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-range, range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(range, -range, 0));
                break;
            case TypeOfChess.Bishop:
                Gizmos.DrawRay(transform.position, new Vector3(range, range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-range, -range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(-range, range, 0));
                Gizmos.DrawRay(transform.position, new Vector3(range, -range, 0));
                break;
            case TypeOfChess.Pawn:
                Gizmos.DrawLine(transform.position, transform.position + Vector3.up * 1);
                break;
            case TypeOfChess.Rook:
                Gizmos.DrawLine(transform.position, transform.position + Vector3.left * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.right * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.up * range);
                Gizmos.DrawLine(transform.position, transform.position + Vector3.down * range);
                break;
            case TypeOfChess.Knights:

                //IDK IDK IDK IDK aaaaaaaaaaaaaaaaahhhhhhhhhhhhhhhhhh
                
                break;
        }
    }
}
