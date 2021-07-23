using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class Fenders : MonoBehaviour
    {
        [SerializeField] private GameObject _leftFender;

        [SerializeField] private GameObject _rightFender;

        public GameObject LeftFender
        {
            get => _leftFender;
            set => _leftFender = value;
        }
        public GameObject RightFender
        {
            get => _rightFender;
            set => _rightFender = value;
        }
    }
}