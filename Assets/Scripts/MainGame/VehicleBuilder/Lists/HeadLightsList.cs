using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "HeadLightsList", menuName = "Vehicle Parts/Lists/HeadLights", order = 0)]
    public class HeadLightsList : ScriptableObject
    {
        [SerializeField] private List<HeadLights> _headLightsList;
    }
}