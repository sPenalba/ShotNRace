using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "RoofList", menuName = "Vehicle Parts/Lists/Roof", order = 0)]
    public class RoofList : ScriptableObject
    {
        [SerializeField] private List<Roof> _roofList;
    }
}