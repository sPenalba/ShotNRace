using System;
using UnityEngine;

namespace Bounzy.Scripts
{
    public enum BlockColors
    {
        blank,
        red,
        blue,
        green,
        yellow,
        cyan,
        white,
        purple
    }

    [Serializable]
    public class LevelConfig
    {
#if UNITY_EDITOR
        public bool showBoard;
#endif
        public int rows = 9;
        public int column = 9;
        public BlockColors[,] board = new BlockColors[10,10];
    }
}