using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "FrontBumperList", menuName = "Vehicle Parts/Lists/FrontBumper", order = 0)]
    public class FrontBumperList : ScriptableObject
    {
        [SerializeField] private List<FrontBumper> _frontBumperList;
    }
}