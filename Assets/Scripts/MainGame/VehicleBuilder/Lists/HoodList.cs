using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "HoodList", menuName = "Vehicle Parts/Lists/Hood", order = 0)]
    public class HoodList : ScriptableObject
    {
        [SerializeField] private List<Hood> _hoodList;
    }
}