using System;
using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class Consumer : MonoBehaviour
    {
        private void Awake()
        {
            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder
                .WithChassis(null)
                .WithTyre(TyrePositions.FrontLeft, null)
                .WithTyre(TyrePositions.FrontRight, null)
                .WithTyre(TyrePositions.RearLeft, null)
                .WithTyre(TyrePositions.RearRight, null)
                .WithFrontBumper(null)
                .WithRearBumper(null)
                .WithSideSkirt(null)
                .WithHood(null)
                .WithRoof(null)
                .WithFenders(null)
                .WithWing(null)
                .WithGrill(null)
                .WithMirrors(null)
                .WithHeadLights(null)
                .WithTailLights(null)
                .WithBottomLights(null)
                .Build();
        }
    }
}