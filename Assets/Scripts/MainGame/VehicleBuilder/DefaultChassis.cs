using System;
using UnityEditor;
using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class DefaultChassis : MonoBehaviour
    {
        [SerializeField] private Chassis _chassis;

        #region FIELDS
        [Header("Tyres")]
        [SerializeField] private Transform _frontRightTyrePosition;

        [SerializeField] private Transform _frontLeftTyrePosition;

        [SerializeField] private Transform _rearRightTyrePosition;

        [SerializeField] private Transform _rearLeftTyrePosition;

        [Space(10)]
        [Header("Aerodynamics")]

        [SerializeField] private Transform _frontBumperPosition;

        [SerializeField] private Transform _rearBumperPosition;

        [SerializeField] private Transform _rightSideSkirtsPosition;

        [SerializeField] private Transform _leftSideSkirtsPosition;

        [SerializeField] private Transform _hoodPosition;

        [SerializeField] private Transform _roofPosition;

        [SerializeField] private Transform _rightFendersPosition;

        [SerializeField] private Transform _leftFendersPosition;

        [SerializeField] private Transform _wingPosition;

        [SerializeField] private Transform _grillPosition;

        [SerializeField] private Transform _rightMirrorsPosition;

        [SerializeField] private Transform _leftMirrorsPosition;

        [Space(10)]
        [Header("Lights")]

        [SerializeField] private Transform _rightHeadLightsPosition;

        [SerializeField] private Transform _leftHeadLightsPosition;

        [SerializeField] private Transform _rightTailLightsPosition;

        [SerializeField] private Transform _leftTailLightsPosition;

        [SerializeField] private Transform _bottomLightsPosition;

        #endregion

        #region METHODS

        public Chassis Chassis
        {
            get => _chassis;
            set => _chassis = value;
        }

        public Transform GetTyrePosition(TyrePositions positions)
        {
            switch (positions)
            {
                case TyrePositions.FrontLeft:
                    return _frontLeftTyrePosition;
                    break;
                case TyrePositions.FrontRight:
                    return _frontRightTyrePosition;
                    break;
                case TyrePositions.RearLeft:
                    return _rearLeftTyrePosition;
                    break;
                case TyrePositions.RearRight:
                    return _rearRightTyrePosition;
                    break;
            }

            throw new ArgumentOutOfRangeException(nameof(positions), positions, null);
        }
        public Transform FrontLeftTyrePosition
        {
            get => _frontLeftTyrePosition;
            set => _frontLeftTyrePosition = value;
        }
        public Transform FrontRightTyrePosition
        {
            get => _frontRightTyrePosition;
            set => _frontRightTyrePosition = value;
        }
        public Transform RearLeftTyrePosition
        {
            get => _rearLeftTyrePosition;
            set => _rearLeftTyrePosition = value;
        }
        public Transform RearRightTyrePosition
        {
            get => _rearRightTyrePosition;
            set => _rearRightTyrePosition = value;
        }

        public Transform FrontBumperPosition
        {
            get => _frontBumperPosition;
            set => _frontBumperPosition = value;
        }

        public Transform RearBumperPosition
        {
            get => _rearBumperPosition;
            set => _rearBumperPosition = value;
        }

        public Transform LeftSideSkirtsPosition
        {
            get => _leftSideSkirtsPosition;
            set => _leftSideSkirtsPosition = value;
        }

        public Transform RightSideSkirtsPosition
        {
            get => _rightSideSkirtsPosition;
            set => _rightSideSkirtsPosition = value;
        }

        public Transform HoodPosition
        {
            get => _hoodPosition;
            set => _hoodPosition = value;
        }

        public Transform RoofPosition
        {
            get => _roofPosition;
            set => _roofPosition = value;
        }

        public Transform RightFendersPosition
        {
            get => _rightFendersPosition;
            set => _rightFendersPosition = value;
        }

        public Transform LeftFendersPosition
        {
            get => _leftFendersPosition;
            set => _leftFendersPosition = value;
        }

        public Transform WingPosition
        {
            get => _wingPosition;
            set => _wingPosition = value;
        }

        public Transform GrillPosition
        {
            get => _grillPosition;
            set => _grillPosition = value;
        }

        public Transform LeftMirrorsPosition
        {
            get => _leftMirrorsPosition;
            set => _leftMirrorsPosition = value;
        }

        public Transform RightMirrorsPosition
        {
            get => _rightMirrorsPosition;
            set => _rightMirrorsPosition = value;
        }

        public Transform RightHeadLightsPosition
        {
            get => _rightHeadLightsPosition;
            set => _rightHeadLightsPosition = value;
        }

        public Transform LeftHeadLightsPosition
        {
            get => _leftHeadLightsPosition;
            set => _leftHeadLightsPosition = value;
        }

        public Transform RightTailLightsPosition
        {
            get => _rightTailLightsPosition;
            set => _rightTailLightsPosition = value;
        }

        public Transform LeftTailLightsPosition
        {
            get => _leftTailLightsPosition;
            set => _leftTailLightsPosition = value;
        }

        public Transform BottomLightsPosition
        {
            get => _bottomLightsPosition;
            set => _bottomLightsPosition = value;
        }

        #endregion
    }
}