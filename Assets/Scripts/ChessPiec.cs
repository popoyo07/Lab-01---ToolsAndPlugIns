using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public class ChessPiec : MonoBehaviour
{
    public float value = 7.0f;
    // array or enum
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        
    }
}

[CustomEditor(typeof(ChessPiec))]
public class ExampleEditor : Editor
{
    private Texture2D king;
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    private void OnEnable()
    {
        king = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/asset/Chess_KingW.png", typeof(Texture));
    }
    public void OnSceneGUI()
    {
        var t = target as ChessPiec;
        var tr = t.transform.position;
        var screenPos = HandleUtility.WorldToGUIPoint(tr);
      
      //  Handles.color = color;
        if (king != null)
        {
            Handles.BeginGUI();
            GUI.DrawTexture(new Rect(screenPos.x - 16, screenPos.y - 16, 32, 32), king);
            Handles.EndGUI();
        }else
        {
            Debug.Log("NO");
        }
   
    }
}
