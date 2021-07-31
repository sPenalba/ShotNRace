using UnityEngine;

namespace Bounzy.Scripts
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    public abstract class Block : ScriptableObject
    {
        [Header("Block Parameters")]
        [SerializeField] private string id;
        [SerializeField] private string description;
        [SerializeField] private int life = 2;
        [SerializeField] private int width = 1;
        [SerializeField] private int height = 1;
        [SerializeField] private int speed = 1;

        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public int Life
        {
            get => life;
            set => life = value;
        }
        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        protected abstract void Movement();
    }
}