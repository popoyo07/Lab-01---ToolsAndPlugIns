using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    public Sprite p;
    void OnDrawGizmos()
    {
        // Draws the Light bulb icon at position of the object.
        // Because we draw it inside OnDrawGizmos the icon is also pickable
        // in the scene view.
        Gizmos.DrawIcon(transform.position, "Chess_BishopW.png", true, Color.red);
    }
}
