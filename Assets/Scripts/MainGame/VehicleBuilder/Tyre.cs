using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class Tyre : ScriptableObject
    {
        [Header("Tyre Info")]

        [SerializeField] private string _tyreId;
        [SerializeField] private string _tyreName;
        [SerializeField] private GameObject _tyrePrefab;
        [SerializeField] private Sprite _tyreIcon;

        public string TyreId
        {
            get => _tyreId;
            set => _tyreId = value;
        }
        public string TyreName
        {
            get => _tyreName;
            set => _tyreName = value;
        }
        public GameObject TyrePrefab
        {
            get => _tyrePrefab;
            set => _tyrePrefab = value;
        }

        public Sprite TyreIcon
        {
            get => _tyreIcon;
            set => _tyreIcon = value;
        }
    }
}