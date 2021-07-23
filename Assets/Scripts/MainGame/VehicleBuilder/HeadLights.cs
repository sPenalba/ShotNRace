using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class HeadLights : MonoBehaviour
    {
        [SerializeField] private GameObject _leftHeadLight;
        [SerializeField] private GameObject _rightHeadLight;

        public GameObject LeftHeadLight
        {
            get => _leftHeadLight;
            set => _leftHeadLight = value;
        }
        public GameObject RightHeadLight
        {
            get => _rightHeadLight;
            set => _rightHeadLight = value;
        }
    }
}