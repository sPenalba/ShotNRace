using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "RearBumperList", menuName = "Vehicle Parts/Lists/RearBumper", order = 0)]
    public class RearBumperList : ScriptableObject
    {
        [SerializeField] private List<RearBumper> _rearBumperList;
    }
}