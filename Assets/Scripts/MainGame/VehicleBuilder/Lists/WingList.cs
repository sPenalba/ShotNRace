using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "WingList", menuName = "Vehicle Parts/Lists/Wing", order = 0)]
    public class WingList : ScriptableObject
    {
        [SerializeField] private List<Wing> _wingList;
    }
}