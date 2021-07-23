using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class Mirrors : MonoBehaviour
    {
        [SerializeField] private GameObject _leftMirror;

        [SerializeField] private GameObject _rightMirror;

        public GameObject LeftMirror
        {
            get => _leftMirror;
            set => _leftMirror = value;
        }
        public GameObject RightMirror
        {
            get => _rightMirror;
            set => _rightMirror = value;
        }
    }
}