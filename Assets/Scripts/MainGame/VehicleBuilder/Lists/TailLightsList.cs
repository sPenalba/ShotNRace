using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "TailLightsList", menuName = "Vehicle Parts/Lists/TailLights", order = 0)]
    public class TailLightsList : ScriptableObject
    {
        [SerializeField] private List<TailLights> _tailLightsList;
    }
}