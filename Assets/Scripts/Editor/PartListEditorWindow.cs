using System;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class PartListEditorWindow : EditorWindow
    {
        public string chassisId;
        public string chassisName;
        public GameObject chassisModel;
        public Sprite chassisIcon;

        [MenuItem("Main Game/Create New Part/Create New Chassis")]
       private static void ShowWindow()
        {
            var window = GetWindow<PartListEditorWindow>();
            window.titleContent = new GUIContent("Create New Chassis");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.BeginVertical();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Id", GUILayout.Width(50));
            chassisId = EditorGUILayout.TextField(chassisId);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Name", GUILayout.Width(50));
            chassisName = EditorGUILayout.TextField(chassisName);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Icon", GUILayout.Width(50));
            chassisIcon = (Sprite) EditorGUILayout.ObjectField(chassisIcon, typeof(Sprite), true);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Model", GUILayout.Width(50));
            chassisModel = (GameObject) EditorGUILayout.ObjectField(chassisModel, typeof(GameObject), true);
            GUILayout.EndHorizontal();

            GUILayout.EndVertical();

            if(GUILayout.Button(("Create Chassis"), GUILayout.Width(100), GUILayout.Height(40)))
            {
                PartListsEditor.CreateChassis(chassisId, chassisName, chassisModel, chassisIcon);
            }
        }
    }
}