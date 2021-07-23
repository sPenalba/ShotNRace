using System.Collections.Generic;
using UnityEngine;

namespace MainGame.VehicleBuilder.Lists
{
    [CreateAssetMenu(fileName = "TyresList", menuName = "Vehicle Parts/Lists/Tyre", order = 0)]
    public class TyresList : ScriptableObject
    {
        [SerializeField] private List<Tyre> _tyresList;

        public List<Tyre> TyreList
        {
            get => _tyresList;
            set => _tyresList = value;
        }
    }
}