
using UnityEngine;
using UnityEngine.UI;


public class Testing : MonoBehaviour
{
    private float cellSize = 1f;  // Size of each cell
    private int gridSize = 8;     // 8x8 chessboard

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        float totalSize = gridSize * cellSize;

        // Draw vertical lines
        for (int x = 0; x <= gridSize; x++)
        {
            Vector3 start = new Vector3(x * cellSize, 0, 0);
            Vector3 end = new Vector3(x * cellSize, totalSize, 0);
            Gizmos.DrawLine(start, end);
        }

        // Draw horizontal lines
        for (int y = 0; y <= gridSize; y++)
        {
            Vector3 start = new Vector3(0, y * cellSize, 0);
            Vector3 end = new Vector3(totalSize, y * cellSize, 0);
            Gizmos.DrawLine(start, end);
        }
    }
}
