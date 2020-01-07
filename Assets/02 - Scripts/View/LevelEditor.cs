using UnityEditor;
using UnityEngine;

public class LevelEditor : EditorWindow
{
    private Vector2 offset;
    private Vector2 drag;

    [MenuItem("Window/Level Editor")]
    private static void OpenWindow()
    {
        var window = GetWindow<LevelEditor>();
        window.titleContent = new GUIContent("Level Editor");
    }
    
    private void OnGUI()
    {
        DrawGrid(50, 0.4f, Color.gray);
        DrawNodes();
        
        GUI.BeginGroup(new Rect(100, 0, 200, 500));
        EditorGUI.DrawRect(new Rect(20, 20, 20, 20), Color.black);
        GUI.EndGroup();

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
        var widthDivs = Mathf.CeilToInt(position.width / gridSpacing);
        var heightDivs = Mathf.CeilToInt(position.height / gridSpacing);

        Handles.BeginGUI();
        Handles.color = new Color(gridColor.r, gridColor.g, gridColor.b, gridOpacity);

        offset += drag * 0.5f;
        var newOffset = new Vector3(offset.x % gridSpacing, offset.y % gridSpacing, 0);
        
        for (var i = 0; i < widthDivs; i++)
        {
            Handles.DrawLine(new Vector3(gridSpacing * i, -gridSpacing, 0) + newOffset,
                new Vector3(gridSpacing * i, position.height, 0f) + newOffset);
        }

        for (var j = 0; j < heightDivs; j++)
        {
            Handles.DrawLine(new Vector3(-gridSpacing, gridSpacing * j, 0) + newOffset,
                new Vector3(position.width, gridSpacing * j, 0f) + newOffset);
        }

        Handles.color = Color.white;
        Handles.EndGUI();
    }
}