using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "SideSkirtList", menuName = "Vehicle Parts/Lists/SideSkirt", order = 0)]
    public class SideSkirtList : ScriptableObject
    {
        [SerializeField] private List<SideSkirt> _sideSkirtList;
    }
}