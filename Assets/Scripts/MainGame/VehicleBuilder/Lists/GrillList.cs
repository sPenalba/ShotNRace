using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "GrillList", menuName = "Vehicle Parts/Lists/Grill", order = 0)]
    public class GrillList : ScriptableObject
    {
        [SerializeField] private List<Grill> _grillList;
    }
}