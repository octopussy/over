using UnityEditor;
using UnityEngine;

namespace View
{
    [CustomEditor(typeof(WorldTester))]
    public class WorldTesterEditor: Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Reload"))
            {
                (target as WorldTester).Reload();
            }
            
            Debug.Log("asdasdasd");
        }
    }
}