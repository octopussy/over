using UnityEditor;
using UnityEngine;

public class LevelEditor : EditorWindow
{
    private Vector2 offset;
    private Vector2 drag;
    
    [MenuItem("Window/Level Editor")]
    private static void OpenWindow()
    {
        LevelEditor window = GetWindow<LevelEditor>();
        window.titleContent = new GUIContent("Level Editor");
    }
 
    private void OnGUI()
    {
        DrawGrid(50, 0.4f, Color.gray);
        DrawNodes();
 
        ProcessEvents(Event.current);
 
        if (GUI.changed) Repaint();
    }
 
    private void DrawNodes()
    {
    }
 
    private void ProcessEvents(Event e)
    {
    }
    
    private void DrawGrid(float gridSpacing, float gridOpacity, Color gridColor)
    {
        int widthDivs = Mathf.CeilToInt(position.width / gridSpacing);
        int heightDivs = Mathf.CeilToInt(position.height / gridSpacing);
 
        Handles.BeginGUI();
        Handles.color = new Color(gridColor.r, gridColor.g, gridColor.b, gridOpacity);
 
        offset += drag * 0.5f;
        Vector3 newOffset = new Vector3(offset.x % gridSpacing, offset.y % gridSpacing, 0);
 
        for (int i = 0; i < widthDivs; i++)
        {
            Handles.DrawLine(new Vector3(gridSpacing * i, -gridSpacing, 0) + newOffset, new Vector3(gridSpacing * i, position.height, 0f) + newOffset);
        }
 
        for (int j = 0; j < heightDivs; j++)
        {
            Handles.DrawLine(new Vector3(-gridSpacing, gridSpacing * j, 0) + newOffset, new Vector3(position.width, gridSpacing * j, 0f) + newOffset);
        }
 
        Handles.color = Color.white;
        Handles.EndGUI();
    }
}