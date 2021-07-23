using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "MirrorsList", menuName = "Vehicle Parts/Lists/Mirrors", order = 0)]
    public class MirrorsList : ScriptableObject
    {
        [SerializeField] private List<Mirrors> _mirrorsList;
    }
}