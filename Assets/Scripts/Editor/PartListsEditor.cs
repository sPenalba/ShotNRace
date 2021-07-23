using System;
using MainGame.VehicleBuilder;
using MainGame.VehicleBuilder.Lists;
using UnityEditor;
using UnityEngine;

namespace Editor
{
#if UNITY_EDITOR
    [CustomEditor(typeof(PartLists))]
    public class PartListsEditor : UnityEditor.Editor
    {
        private const string DataPath = "Assets/Data/VehicleParts/";
        private const string PrefabPath = "Assets/Prefabs/VehicleParts/";

        private bool showCreateButton = false;
        private static PartLists _target;

        private void OnEnable()
        {
            _target = (PartLists) target;
        }

        public override void OnInspectorGUI()
        {
            if(showCreateButton)
            {
                GUILayout.BeginVertical();
                if (GUILayout.Button("CREATE PART LISTS", GUILayout.Height(20))) CreateLists();
                GUILayout.Space(10);
                GUILayout.EndVertical();
            }

            GUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            if (_target.ChassisList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE CHASSIS TYPE", GUILayout.Height(20))) CreateChassis(null, null, null, null);
            GUILayout.Label(_target.ChassisList.chassisList.Count.ToString());
            GUILayout.EndHorizontal();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.TyresList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE TYRE TYPE", GUILayout.Height(20))) CreateTyre(null, null, null, null);
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.FendersList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE FENDERS TYPE", GUILayout.Height(20))) CreateFenders();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.GrillList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE GRILL TYPE", GUILayout.Height(20))) CreateGrill();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.HoodList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE HOOD TYPE", GUILayout.Height(20))) CreateHood();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.MirrorsList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE MIRROR TYPE", GUILayout.Height(20))) CreateMirror();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.RoofList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE ROOF TYPE", GUILayout.Height(20))) CreateRoof();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.WingList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE WING TYPE", GUILayout.Height(20))) CreateWing();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.BottomLightsList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE BOTTOM LIGHT TYPE", GUILayout.Height(20))) CreateBottomLight();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.HeadLightsList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE HEADLIGHT TYPE", GUILayout.Height(20))) CreateHeadLight();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.TailLightsList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE TAILLIGHT TYPE", GUILayout.Height(20))) CreateTailLight();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.FrontBumperList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE FRONT BUMPER TYPE", GUILayout.Height(20))) CreateFrontBumper();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.RearBumperList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE REAR BUMPER TYPE", GUILayout.Height(20))) CreateRearBumper();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.SideSkirtList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE SIDE SKIRT TYPE", GUILayout.Height(20))) CreateSideSkirt();
            GUILayout.Space(10);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            if (_target.SideSkirtList == null)
            {
                GUI.backgroundColor = Color.red;
                showCreateButton = true;
            }
            if (GUILayout.Button("CREATE SIDE SKIRT TYPE", GUILayout.Height(20))) CreateSideSkirt();
            GUILayout.Space(10);
            GUILayout.EndVertical();


            serializedObject.ApplyModifiedProperties();
            base.OnInspectorGUI();
        }

        private void CreateFenders()
        {
            throw new NotImplementedException();
        }

        private void CreateGrill()
        {
            throw new NotImplementedException();
        }

        private void CreateHood()
        {
            throw new NotImplementedException();
        }

        private void CreateMirror()
        {
            throw new NotImplementedException();
        }

        private void CreateRoof()
        {
            throw new NotImplementedException();
        }

        private void CreateWing()
        {
            throw new NotImplementedException();
        }

        private void CreateBottomLight()
        {
            throw new NotImplementedException();
        }

        private void CreateHeadLight()
        {
            throw new NotImplementedException();
        }

        private void CreateTailLight()
        {
            throw new NotImplementedException();
        }

        private void CreateFrontBumper()
        {
            throw new NotImplementedException();
        }

        private void CreateRearBumper()
        {
            throw new NotImplementedException();
        }

        private void CreateSideSkirt()
        {
            throw new NotImplementedException();
        }

        public static void CreateTyre(String id, String name, GameObject defaultMesh, Sprite defaultIcon)
        {
            Selection.activeObject = _target;

            var tyre = CreateInstance<Tyre>();
            var list = _target.TyresList.TyreList;

            if(!AssetDatabase.IsValidFolder(DataPath + "Tyres/"))
                AssetDatabase.CreateFolder(DataPath, "Tyres");

            if(!AssetDatabase.IsValidFolder(PrefabPath + "Tyres/"))
                AssetDatabase.CreateFolder(PrefabPath, "Tyres");

            AssetDatabase.CreateAsset(tyre, DataPath + "Tyres/" + (list.Count + 1) + "_" + name + ".asset");

            var go = new GameObject("New Tyre");

            ObjectFactory.AddComponent<DefaultTyre>(go).Tyre = tyre;

            var prefab = PrefabUtility.CreatePrefab(PrefabPath + "Tyres/" + (list.Count + 1) + "_"+ name + ".prefab", go);

            prefab.GetComponent<DefaultTyre>().Tyre = tyre;

            tyre.TyrePrefab = prefab;

            EditorUtility.FocusProjectWindow();

            DestroyImmediate(go);

            Selection.activeObject = prefab;
            list.Add(tyre);

        }

        public static void CreateChassis(String id, String name, GameObject defaultMesh, Sprite defaultIcon)
        {
            Selection.activeObject = _target;

            var chassis = CreateInstance<Chassis>();
            var list = _target.ChassisList.chassisList;

            if(!AssetDatabase.IsValidFolder(DataPath + "Chassis/"))
                AssetDatabase.CreateFolder(DataPath, "Chassis");

            if(!AssetDatabase.IsValidFolder(PrefabPath + "Chassis/"))
                AssetDatabase.CreateFolder(PrefabPath, "Chassis");

            AssetDatabase.CreateAsset(chassis, DataPath + "Chassis/" + (list.Count + 1) + "_" + name + ".asset");
            
            var go = new GameObject("New Chassis");
            var mesh = new GameObject("Mesh");

            ObjectFactory.AddComponent<DefaultChassis>(go).Chassis = chassis;

            var _chassis = go.GetComponent<DefaultChassis>();
            
            mesh.transform.parent = go.transform;
            

            
            _chassis.Chassis = chassis;
            _chassis.Chassis.ChassisId = id;
            _chassis.Chassis.ChassisName = name;
            _chassis.Chassis.ChassisPrefab = defaultMesh;
            _chassis.Chassis.ChassisIcon = defaultIcon;

            chassis.ChassisId = id;
            chassis.ChassisName = name;
            chassis.ChassisPrefab = defaultMesh;
            chassis.ChassisIcon = defaultIcon;

            //Create Body and parents to main GameObject
            var body = new GameObject("Body");
            body.transform.parent = mesh.transform;

            var tyre = new GameObject("Tyre");
            tyre.transform.parent = mesh.transform;

            var lights = new GameObject("Lights");
            lights.transform.parent = mesh.transform;

            //Create tyres and parent to Tyre
            var frontRightTyrePosition = new GameObject("FrontRight");
            frontRightTyrePosition.transform.parent = tyre.transform;
            frontRightTyrePosition.transform.localPosition = new Vector3(1,1,1);

            var frontLeftTyrePosition = new GameObject("FrontLeft");
            frontLeftTyrePosition.transform.parent = tyre.transform;
            frontLeftTyrePosition.transform.localPosition = new Vector3(-1,1,1);

            var rearRightTyrePosition = new GameObject("RearRight");
            rearRightTyrePosition.transform.parent = tyre.transform;
            frontRightTyrePosition.transform.localPosition = new Vector3(1,1,-1);


            var rearLeftTyrePosition = new GameObject("RearLeft");
            rearLeftTyrePosition.transform.parent = tyre.transform;
            rearLeftTyrePosition.transform.localPosition = new Vector3(-1,1,-1);

            //Create body parts and parent to Body
            var frontBumperPosition = new GameObject("FrontBumper");
            frontBumperPosition.transform.parent = body.transform;
            frontBumperPosition.transform.localPosition = new Vector3(0,0,1.25f);

            var rearBumperPosition = new GameObject("RearBumper");
            rearBumperPosition.transform.parent = body.transform;
            rearBumperPosition.transform.localPosition = new Vector3(0,0,-1.25f);

            var rSideSkirtPosition = new GameObject("RightSideSkirt");
            rSideSkirtPosition.transform.parent = body.transform;
            rSideSkirtPosition.transform.localPosition = new Vector3(1,0,0);

            var lSideSkirtPosition = new GameObject("LeftSideSkirt");
            lSideSkirtPosition.transform.parent = body.transform;
            lSideSkirtPosition.transform.localPosition = new Vector3(-1,0,0);

            var rFenderPosition = new GameObject("RightFender");
            rFenderPosition.transform.parent = body.transform;
            rFenderPosition.transform.localPosition = new Vector3(1,0,0.6f);

            var lFenderPosition = new GameObject("LeftFender");
            lFenderPosition.transform.parent = body.transform;
            lFenderPosition.transform.localPosition = new Vector3(-1,0,0.6f);

            var rMirrorPosition = new GameObject("RightMirror");
            rMirrorPosition.transform.parent = body.transform;
            rMirrorPosition.transform.localPosition = new Vector3(1,1,1);

            var lMirrorPosition = new GameObject("LeftMirror");
            lMirrorPosition.transform.parent = body.transform;
            lMirrorPosition.transform.localPosition = new Vector3(-1,1,1);

            var hoodPosition = new GameObject("Hood");
            hoodPosition.transform.parent = body.transform;
            hoodPosition.transform.localPosition = new Vector3(0,1,1);

            var roofPosition = new GameObject("Roof");
            roofPosition.transform.parent = body.transform;
            roofPosition.transform.localPosition = new Vector3(0,1.5f,0);

            var wingPosition = new GameObject("Wing");
            wingPosition.transform.parent = body.transform;
            wingPosition.transform.localPosition = new Vector3(0,1f,-1.2f);

            var grillPosition = new GameObject("Grill");
            grillPosition.transform.parent = body.transform;
            grillPosition.transform.localPosition = new Vector3(0,0.3f,1.2f);

            //Create lights and parent to Lights
            var rHeadLightPosition = new GameObject("RightHeadLight");
            rHeadLightPosition.transform.parent = lights.transform;
            rHeadLightPosition.transform.localPosition = new Vector3(0.6f,1,1);

            var lHeadLightPosition = new GameObject("LeftHeadLight");
            lHeadLightPosition.transform.parent = lights.transform;
            lHeadLightPosition.transform.localPosition = new Vector3(-0.6f,1,1);

            var rTailLightPosition = new GameObject("RightTailLight");
            rTailLightPosition.transform.parent = lights.transform;
            rTailLightPosition.transform.localPosition = new Vector3(0.6f,1,-1);

            var lTailLightPosition = new GameObject("LeftTailLight");
            lTailLightPosition.transform.parent = lights.transform;
            lTailLightPosition.transform.localPosition = new Vector3(-0.6f,1,-1);

            var bottomLightPosition = new GameObject("BottomLight");
            bottomLightPosition.transform.parent = lights.transform;
            bottomLightPosition.transform.localPosition = new Vector3(0,0,0);

            //Set Tyre
            _chassis.FrontLeftTyrePosition = frontLeftTyrePosition.transform;
            _chassis.FrontRightTyrePosition = frontRightTyrePosition.transform;
            _chassis.RearLeftTyrePosition = rearLeftTyrePosition.transform;
            _chassis.RearRightTyrePosition = rearRightTyrePosition.transform;

            //Set Body
            _chassis.GrillPosition = grillPosition.transform;
            _chassis.HoodPosition = hoodPosition.transform;
            _chassis.RoofPosition = roofPosition.transform;
            _chassis.WingPosition = wingPosition.transform;
            _chassis.FrontBumperPosition = frontBumperPosition.transform;
            _chassis.RearBumperPosition = rearBumperPosition.transform;
            _chassis.LeftFendersPosition = lFenderPosition.transform;
            _chassis.RightFendersPosition = rFenderPosition.transform;
            _chassis.LeftMirrorsPosition = lMirrorPosition.transform;
            _chassis.RightMirrorsPosition = rMirrorPosition.transform;
            _chassis.LeftSideSkirtsPosition = lSideSkirtPosition.transform;
            _chassis.RightSideSkirtsPosition = rSideSkirtPosition.transform;

            //Set Lights
            _chassis.BottomLightsPosition = bottomLightPosition.transform;
            _chassis.LeftHeadLightsPosition = lHeadLightPosition.transform;
            _chassis.RightHeadLightsPosition = rHeadLightPosition.transform;
            _chassis.LeftTailLightsPosition = lTailLightPosition.transform;
            _chassis.RightTailLightsPosition = rTailLightPosition.transform;

            var prefab = PrefabUtility.CreatePrefab(PrefabPath + "Chassis/" + (list.Count + 1) + "_"+ name + ".prefab", go);

            prefab.GetComponent<DefaultChassis>().Chassis = chassis;

            chassis.ChassisPrefab = prefab;

            EditorUtility.FocusProjectWindow();

            DestroyImmediate(go);

            Selection.activeObject = prefab;
            list.Add(chassis);
        }

        private void CreateLists()
        {
            if (_target.ChassisList == null)
            {
                var chassisList = CreateInstance<ChassisList>();
                _target.ChassisList = chassisList;
                AssetDatabase.CreateAsset(chassisList, DataPath + "Lists/ChassisList.asset");
            }

            if (_target.TyresList == null)
            {
                var tyreList = CreateInstance<TyresList>();
                _target.TyresList = tyreList;
                AssetDatabase.CreateAsset(tyreList, DataPath + "Lists/TyresList.asset");
            }

            if (_target.FrontBumperList == null)
            {
                var frontBumperList = CreateInstance<FrontBumperList>();
                _target.FrontBumperList = frontBumperList;
                AssetDatabase.CreateAsset(frontBumperList, DataPath + "Lists/FrontBumperList.asset");
            }

            if (_target.RearBumperList == null)
            {
                var rearBumperList = CreateInstance<RearBumperList>();
                _target.RearBumperList = rearBumperList;
                AssetDatabase.CreateAsset(rearBumperList, DataPath + "Lists/RearBumperList.asset");
            }

            if (_target.FendersList == null)
            {
                var fenderList = CreateInstance<FendersList>();
                _target.FendersList = fenderList;
                AssetDatabase.CreateAsset(fenderList, DataPath + "Lists/FendersList.asset");
            }

            if (_target.GrillList == null)
            {
                var grillList = CreateInstance<GrillList>();
                _target.GrillList = grillList;
                AssetDatabase.CreateAsset(grillList, DataPath + "Lists/GrillList.asset");
            }

            if (_target.HoodList == null)
            {
                var hoodList = CreateInstance<HoodList>();
                _target.HoodList = hoodList;
                AssetDatabase.CreateAsset(hoodList, DataPath + "Lists/HoodList.asset");
            }

            if (_target.RoofList == null)
            {
                var roofList = CreateInstance<RoofList>();
                _target.RoofList = roofList;
                AssetDatabase.CreateAsset(roofList, DataPath + "Lists/RoofList.asset");
            }

            if (_target.MirrorsList == null)
            {
                var mirrorsList = CreateInstance<MirrorsList>();
                _target.MirrorsList = mirrorsList;
                AssetDatabase.CreateAsset(mirrorsList, DataPath + "Lists/MirrorsList.asset");
            }

            if (_target.SideSkirtList == null)
            {
                var sideSkirtList = CreateInstance<SideSkirtList>();
                _target.SideSkirtList = sideSkirtList;
                AssetDatabase.CreateAsset(sideSkirtList, DataPath + "Lists/SideSkirtList.asset");
            }

            if (_target.WingList == null)
            {
                var wingList = CreateInstance<WingList>();
                _target.WingList = wingList;
                AssetDatabase.CreateAsset(wingList, DataPath + "Lists/WingList.asset");
            }

            if (_target.HeadLightsList == null)
            {
                var headLightsList = CreateInstance<HeadLightsList>();
                _target.HeadLightsList = headLightsList;
                AssetDatabase.CreateAsset(headLightsList, DataPath + "Lists/HeadLightsList.asset");
            }

            if (_target.TailLightsList == null)
            {
                var tailLightsList = CreateInstance<TailLightsList>();
                _target.TailLightsList = tailLightsList;
                AssetDatabase.CreateAsset(tailLightsList, DataPath + "Lists/TailLightsList.asset");
            }

            if (_target.BottomLightsList == null) return;
            {
                var bottomLightsList = CreateInstance<BottomLightsList>();
                _target.BottomLightsList = bottomLightsList;
                AssetDatabase.CreateAsset(bottomLightsList, DataPath + "Lists/BottomLightsList.asset");
            }

            AssetDatabase.SaveAssets();
        }
    }
#endif
}