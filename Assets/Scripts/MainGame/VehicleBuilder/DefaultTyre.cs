using UnityEngine;

namespace MainGame.VehicleBuilder
{
    public class DefaultTyre : MonoBehaviour
    {
        [SerializeField] private Tyre _tyre;

        public Tyre Tyre
        {
            get => _tyre;
            set => _tyre = value;
        }
    }
}