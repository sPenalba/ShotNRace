using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "FendersList", menuName = "Vehicle Parts/Lists/Fenders", order = 0)]
    public class FendersList : ScriptableObject
    {
        [SerializeField] private List<Fenders> _fendersList;
    }
}