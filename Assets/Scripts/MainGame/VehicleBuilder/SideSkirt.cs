using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class SideSkirt : MonoBehaviour
    {
        [SerializeField] private GameObject _leftSideSkirt;
        [SerializeField] private GameObject _rightSideSkirt;

        public GameObject LeftSideSkirt
        {
            get => _leftSideSkirt;
            set => _leftSideSkirt = value;
        }
        public GameObject RightSideSkirt
        {
            get => _rightSideSkirt;
            set => _rightSideSkirt = value;
        }
    }
}