using System;
using MainGame.VehicleBuilder.Lists;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MainGame.VehicleBuilder
{
    [CreateAssetMenu(fileName = "PartsLists", menuName = "Vehicle Parts/Lists/PartLists", order = 0)]
    public class PartLists : ScriptableObject
    {
        [SerializeField] private ChassisList _chassisList;
        [SerializeField] private TyresList _tyresList;
        [SerializeField] private FrontBumperList _frontBumperList;
        [SerializeField] private RearBumperList _rearBumperList;
        [SerializeField] private FendersList _fendersList;
        [SerializeField] private GrillList _grillList;
        [SerializeField] private HoodList _hoodList;
        [SerializeField] private RoofList _roofList;
        [SerializeField] private MirrorsList _mirrorsList;
        [SerializeField] private SideSkirtList _sideSkirtList;
        [SerializeField] private WingList _wingList;
        [SerializeField] private HeadLightsList _headLightsList;
        [SerializeField] private TailLightsList _tailLightsList;
        [SerializeField] private BottomLightsList _bottomLightsList;

        public ChassisList ChassisList
        {
            get => _chassisList;
            set => _chassisList = value;
        }
        public TyresList TyresList
        {
            get => _tyresList;
            set => _tyresList = value;
        }
        public FrontBumperList FrontBumperList
        {
            get => _frontBumperList;
            set => _frontBumperList = value;
        }
        public RearBumperList RearBumperList
        {
            get => _rearBumperList;
            set => _rearBumperList = value;
        }
        public FendersList FendersList
        {
            get => _fendersList;
            set => _fendersList = value;
        }
        public GrillList GrillList
        {
            get => _grillList;
            set => _grillList = value;
        }
        public HoodList HoodList
        {
            get => _hoodList;
            set => _hoodList = value;
        }
        public RoofList RoofList
        {
            get => _roofList;
            set => _roofList = value;
        }
        public MirrorsList MirrorsList
        {
            get => _mirrorsList;
            set => _mirrorsList = value;
        }
        public SideSkirtList SideSkirtList
        {
            get => _sideSkirtList;
            set => _sideSkirtList = value;
        }
        public WingList WingList
        {
            get => _wingList;
            set => _wingList = value;
        }
        public HeadLightsList HeadLightsList
        {
            get => _headLightsList;
            set => _headLightsList = value;
        }
        public TailLightsList TailLightsList
        {
            get => _tailLightsList;
            set => _tailLightsList = value;
        }
        public BottomLightsList BottomLightsList
        {
            get => _bottomLightsList;
            set => _bottomLightsList = value;
        }
    }
}