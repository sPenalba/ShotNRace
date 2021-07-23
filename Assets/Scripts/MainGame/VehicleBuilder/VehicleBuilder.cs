using System.Collections.Generic;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = System.Numerics.Vector3;

namespace MainGame.VehicleBuilder
{
    public class VehicleBuilder
    {
        private readonly Dictionary<TyrePositions, Tyre> _tyres = new Dictionary<TyrePositions, Tyre>();
        private DefaultChassis _chassis;
        private FrontBumper _frontBumper;
        private RearBumper _rearBumper;
        private SideSkirt _sideSkirt;
        private Hood _hood;
        private Roof _roof;
        private Fenders _fenders;
        private Wing _wing;
        private Grill _grill;
        private Mirrors _mirrors;
        private HeadLights _headLights;
        private TailLights _tailLights;
        private BottomLights _bottomLights;

        private Vector3 _position;
        private Quaternion _rotation;
        private Vehicle _vehicle;

        public VehicleBuilder WithChassis(DefaultChassis chassis)
        {
            _chassis = chassis;
            return this;
        }

        public VehicleBuilder WithTyre(TyrePositions position, Tyre tyre)
        {
            _tyres.Add(position, tyre);
            return this;
        }

        public VehicleBuilder WithFrontBumper(FrontBumper frontBumper)
        {
            _frontBumper = frontBumper;
            return this;
        }

        public VehicleBuilder WithRearBumper(RearBumper rearBumper)
        {
            _rearBumper = rearBumper;
            return this;
        }

        public VehicleBuilder WithSideSkirt(SideSkirt sideSkirt)
        {
            _sideSkirt = sideSkirt;
            return this;
        }

        public VehicleBuilder WithHood(Hood hood)
        {
            _hood = hood;
            return this;
        }

        public VehicleBuilder WithRoof(Roof roof)
        {
            _roof = roof;
            return this;
        }

        public VehicleBuilder WithFenders(Fenders fenders)
        {
            _fenders = fenders;
            return this;
        }

        public VehicleBuilder WithWing(Wing wing)
        {
            _wing = wing;
            return this;
        }

        public VehicleBuilder WithGrill(Grill grill)
        {
            _grill = grill;
            return this;
        }

        public VehicleBuilder WithMirrors(Mirrors mirrors)
        {
            _mirrors = mirrors;
            return this;
        }

        public VehicleBuilder WithHeadLights(HeadLights headLights)
        {
            _headLights = headLights;
            return this;
        }

        public VehicleBuilder WithTailLights(TailLights tailLights)
        {
            _tailLights = tailLights;
            return this;
        }

        public VehicleBuilder WithBottomLights(BottomLights bottomLights)
        {
            _bottomLights = bottomLights;
            return this;
        }

        public VehicleBuilder WithPosition(Vector3 position)
        {
            _position = position;
            return this;
        }

        public VehicleBuilder WithRotation(Quaternion rotation)
        {
            _rotation = rotation;
            return this;
        }

        public VehicleBuilder FromVehiclePrefab(Vehicle vehicle)
        {
            _vehicle = vehicle;
            return this;
        }

        public Vehicle Build()
        {
            var vehicle = Object.Instantiate(_vehicle);
            var chassis = Object.Instantiate(_chassis, vehicle.transform, true);
            var frontBumper = Object.Instantiate(_frontBumper, chassis.FrontBumperPosition);
            var rearBumper = Object.Instantiate(_rearBumper, chassis.RearBumperPosition, true);

            var lSideSkirt = Object.Instantiate(_sideSkirt.LeftSideSkirt, chassis.LeftSideSkirtsPosition, true);
            var rSideSkirt = Object.Instantiate(_sideSkirt.RightSideSkirt, chassis.RightSideSkirtsPosition, true);

            var hood = Object.Instantiate(_hood, chassis.HoodPosition, true);
            var roof = Object.Instantiate(_roof, chassis.RoofPosition, true);

            var lFenders = Object.Instantiate(_fenders.LeftFender, chassis.LeftFendersPosition, true);
            var rFenders = Object.Instantiate(_fenders.RightFender, chassis.RightFendersPosition, true);

            var wing = Object.Instantiate(_wing, chassis.WingPosition, true);
            var grill = Object.Instantiate(_grill, chassis.GrillPosition, true);

            var lMirrors = Object.Instantiate(_mirrors.LeftMirror, chassis.LeftMirrorsPosition, true);
            var rMirrors = Object.Instantiate(_mirrors.RightMirror, chassis.RightMirrorsPosition, true);

            var lHeadLights = Object.Instantiate(_headLights.LeftHeadLight, chassis.LeftHeadLightsPosition, true);
            var rHeadLights = Object.Instantiate(_headLights.RightHeadLight, chassis.RightHeadLightsPosition, true);

            var lTailLights = Object.Instantiate(_tailLights.LeftTailLight, chassis.LeftTailLightsPosition, true);
            var rTailLights = Object.Instantiate(_tailLights.RightTailLight, chassis.RightTailLightsPosition, true);

            var bottomLights = Object.Instantiate(_bottomLights, chassis.BottomLightsPosition, true);

            var tyres = new Dictionary<TyrePositions, Tyre>();

            foreach (var tyre in _tyres)
            {
                var tyreInstance = Object.Instantiate(tyre.Value, chassis.GetTyrePosition(tyre.Key));
                tyres.Add(tyre.Key, tyreInstance);
            }
            vehicle.SetComponents(tyres, chassis, frontBumper,
                rearBumper, _sideSkirt, hood, roof, _fenders, wing,
                grill, _mirrors, _headLights, _tailLights, bottomLights);

            return vehicle;
        }
    }
}