using System.Collections.Generic;
using UnityEngine;

namespace Bounzy.Scripts
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
    public class BlockList : ScriptableObject
    {
        [SerializeField] private List<BlockDefault> blockDefaults;

        public List<BlockDefault> BlockDefaults
        {
            get => blockDefaults;
            set => blockDefaults = value;
        }
    }
}