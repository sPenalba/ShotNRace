using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "BottomLightsList", menuName = "Vehicle Parts/Lists/BottomLights", order = 0)]
    public class BottomLightsList : ScriptableObject
    {
        [SerializeField] private List<BottomLights> _bottomLightsList;
    }
}