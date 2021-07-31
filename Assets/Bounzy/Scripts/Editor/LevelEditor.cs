using UnityEditor;
using UnityEngine;

namespace Bounzy.Scripts.Editor
{
    [CustomEditor(typeof(Levels))]
    public class LevelEditor : UnityEditor.Editor
    {
        public bool showLevels = true;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var levels = (Levels) target;
            EditorGUILayout.Space();

            showLevels = EditorGUILayout.Foldout(showLevels, "Levels (" + levels.allLevels.Count + ")");
            if (showLevels)
            {
                EditorGUI.indentLevel++;
                for (ushort i = 0; i < levels.allLevels.Count; i++)
                {
                    levels.allLevels[i].showBoard = EditorGUILayout.Foldout(levels.allLevels[i].showBoard, "Board");
                    if (levels.allLevels[i].showBoard)
                    {
                        EditorGUI.indentLevel = 0;

                        var tableStyle = new GUIStyle("box");
                        tableStyle.padding = new RectOffset(10, 10, 10, 10);
                        tableStyle.margin.left = 32;

                        var headerColumnStyle = new GUIStyle();
                        headerColumnStyle.fixedWidth = 35;

                        var columnStyle = new GUIStyle();
                        columnStyle.fixedWidth = 65;

                        var rowStyle = new GUIStyle();
                        rowStyle.fixedHeight = 25;

                        var rowHeaderStyle = new GUIStyle();
                        rowHeaderStyle.fixedWidth = columnStyle.fixedWidth - 1;

                        var columnHeaderStyle = new GUIStyle();
                        columnHeaderStyle.fixedWidth = 30;
                        columnHeaderStyle.fixedHeight = 25.5f;

                        var columnLabelStyle = new GUIStyle();
                        columnLabelStyle.fixedWidth = rowHeaderStyle.fixedWidth - 6;
                        columnLabelStyle.alignment = TextAnchor.MiddleCenter;
                        columnLabelStyle.fontStyle = FontStyle.Bold;

                        var cornerLabelStyle = new GUIStyle();
                        cornerLabelStyle.fixedWidth = 42;
                        cornerLabelStyle.alignment = TextAnchor.MiddleRight;
                        cornerLabelStyle.fontStyle = FontStyle.BoldAndItalic;
                        cornerLabelStyle.fontSize = 14;
                        cornerLabelStyle.padding.top = -5;

                        var rowLabelStyle = new GUIStyle();
                        rowLabelStyle.fixedWidth = 25;
                        rowLabelStyle.alignment = TextAnchor.MiddleRight;
                        rowLabelStyle.fontStyle = FontStyle.Bold;

                        var enumStyle = new GUIStyle("popup");
                        rowStyle.fixedWidth = 65;

                        EditorGUILayout.BeginHorizontal(tableStyle);
                        for (var x = -1; x < levels.allLevels[i].column; x++)
                        {
                            EditorGUILayout.BeginVertical(x == -1 ? headerColumnStyle : columnStyle);
                            for (var y = -1; y < levels.allLevels[i].rows; y++)
                            {
                                if (x == -1 && y == -1)
                                {
                                    EditorGUILayout.BeginVertical(rowHeaderStyle);
                                    EditorGUILayout.LabelField("[X,Y]", cornerLabelStyle);
                                    EditorGUILayout.EndHorizontal();
                                }
                                else if (x == -1)
                                {
                                    EditorGUILayout.BeginVertical(columnHeaderStyle);
                                    EditorGUILayout.LabelField(y.ToString(), rowLabelStyle);
                                    EditorGUILayout.EndHorizontal();
                                }
                                else if (y == -1)
                                {
                                    EditorGUILayout.BeginVertical(rowHeaderStyle);
                                    EditorGUILayout.LabelField(x.ToString(), columnLabelStyle);
                                    EditorGUILayout.EndHorizontal();
                                }

                                if (x >= 0 && y >= 0)
                                {
                                    EditorGUILayout.BeginHorizontal(rowStyle);
                                    levels.allLevels[i].board[x, y] =
                                        (BlockColors) EditorGUILayout.EnumPopup(levels.allLevels[i].board[x, y],
                                            enumStyle);
                                    EditorGUILayout.EndHorizontal();
                                }
                            }

                            EditorGUILayout.EndVertical();
                        }

                        EditorGUILayout.EndHorizontal();
                    }
                }
            }
        }
    }
}