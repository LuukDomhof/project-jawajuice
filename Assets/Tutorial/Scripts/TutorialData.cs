using Jawa.Utility;
using System;
using UnityEditor;
using UnityEngine;

namespace Jawa.Tutorial
{
    public class TutorialData : ScriptableObject
    {
        [Serializable]
        public struct TutorialEntry
        {
            public string Name;

            public string Text;
        }


        public TutorialEntry[] Entries;


        [MenuItem("Assets/Create/Jawa/Tutorial Data")]
        public static void CreateAsset()
        {
            AssetUtility.CreateAsset<TutorialData>();
        }
    }
}
