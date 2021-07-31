using System;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class PartListEditorWindow : EditorWindow
    {
        public GUISkin skin;

        //Chassis Data
        public string chassisId;
        public string chassisName;
        public GameObject chassisModel;
        public Sprite chassisIcon;

        //Tyre Data
        public string _tyreId;
        public string _tyreName;
        public GameObject _tyrePrefab;
        public Sprite _tyreIcon;

        //Toggles
        private bool _headerToggleGroup;
        private bool _isCreateNewPart = false;
        private bool _isPartLists = false;

        private bool _isChassis = false;
        private bool _isTyre = false;

        [MenuItem("Main Game/Create New Part/Create New Parts")]
       private static void ShowWindow()
        {
            var window = GetWindow<PartListEditorWindow>();
            window.titleContent = new GUIContent("CREATE NEW PARTS");
            window.Show();
        }

        private void OnGUI()
        {
            skin = AssetDatabase.LoadAssetAtPath("Assets/Art/GuiStyle/GUISkin.guiskin", typeof(GUISkin)) as GUISkin;
            GUI.skin = skin;

            EditorGUILayout.BeginHorizontal();
            // GUILayout.Label("CREATE NEW PART","button");
            GUILayout.ExpandWidth(true);
            _isPartLists = GUILayout.Button("PART LIST");
            _isCreateNewPart = GUILayout.Button("CREATE NEW PART");

            if (_isPartLists)
            {
                _isPartLists = true;
            }
            if (_isCreateNewPart)
            {
                _isCreateNewPart = true;
            }

            // GUILayout.Label("PART LISTS","button");
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginVertical("box", GUILayout.MaxWidth(150), GUILayout.ExpandHeight(true));


            GUILayout.Space(10);

            _isChassis = EditorGUILayout.Toggle("CREATE CHASSIS", _isChassis, "button");
            // EditorGUILayout.EndHorizontal();
            if(_isChassis)
            {
                EditorGUILayout.BeginVertical("box", GUILayout.ExpandHeight(true));
                DrawNewChassisWindow();
            }

            EditorGUILayout.EndVertical();
        }

        private void DrawNewChassisWindow()
        {
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

            GUILayout.BeginHorizontal();
            if (GUILayout.Button(("CREATE CHASSIS"), GUILayout.Width(160), GUILayout.Height(40)))
            {
                PartListsEditor.CreateChassis(chassisId, chassisName, chassisModel, chassisIcon);
            }
            GUILayout.EndHorizontal();

            EditorGUILayout.EndVertical();
        }
    }
}