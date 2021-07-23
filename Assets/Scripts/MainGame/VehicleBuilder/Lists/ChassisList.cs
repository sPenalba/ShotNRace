using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "ChassisList", menuName = "Vehicle Parts/Lists/Chassis", order = 0)]
    public class ChassisList : ScriptableObject
    {
        [SerializeField] private List<Chassis> _chassisList;

        public List<Chassis> chassisList
        {
            get => _chassisList;
            set => _chassisList = value;
        }
    }
}