using System;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace MainGame.VehicleBuilder
{
    public class Chassis : ScriptableObject
    {
        [Header("Chassis Info")]

        [SerializeField] private string _chassisId;
        [SerializeField] private string _chassisName;
        [SerializeField] private GameObject _chassisPrefab;
        [SerializeField] private Sprite _chassisIcon;

        public string ChassisId
        {
            get => _chassisId;
            set => _chassisId = value;
        }
        public string ChassisName
        {
            get => _chassisName;
            set => _chassisName = value;
        }
        public GameObject ChassisPrefab
        {
            get => _chassisPrefab;
            set => _chassisPrefab = value;
        }

        public Sprite ChassisIcon
        {
            get => _chassisIcon;
            set => _chassisIcon = value;
        }
    }
}