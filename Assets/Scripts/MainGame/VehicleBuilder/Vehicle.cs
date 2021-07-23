using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class Vehicle : MonoBehaviour
    {
        private Dictionary<TyrePositions, Tyre> _tyres;
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

        public void SetComponents(Dictionary<TyrePositions, Tyre> tyres, DefaultChassis chassis, FrontBumper frontBumper,
            RearBumper rearBumper, SideSkirt sideSkirt, Hood hood, Roof roof, Fenders fenders, Wing wing, Grill grill,
            Mirrors mirrors, HeadLights headlights, TailLights tailLights, BottomLights bottomLights)
        {
            _tyres = tyres;
            _chassis = chassis;
            _frontBumper = frontBumper;
            _rearBumper = rearBumper;
            _sideSkirt = sideSkirt;
            _hood = hood;
            _roof = roof;
            _fenders = fenders;
            _wing = wing;
            _grill = grill;
            _mirrors = mirrors;
            _headLights = headlights;
            _tailLights = tailLights;
            _bottomLights = bottomLights;
        }
    }
}