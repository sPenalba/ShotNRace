using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class TailLights : MonoBehaviour
    {
        [SerializeField] private GameObject _leftTailLight;
        [SerializeField] private GameObject _rightTailLight;

        public GameObject LeftTailLight
        {
            get => _leftTailLight;
            set => _leftTailLight = value;
        }
        public GameObject RightTailLight
        {
            get => _rightTailLight;
            set => _rightTailLight = value;
        }
    }
}