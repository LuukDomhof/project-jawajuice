using Jawa.Utility;
using UnityEngine;

namespace Jawa.Tutorial
{
    public class TutorialEvent : GameObjectEvent
    {
        public string TutorialEntryName;


        public TutorialEvent(GameObject gameObject = null, string tutorialEntryName = null)
            : base(gameObject)
        {
            TutorialEntryName = tutorialEntryName;
        }
    }
}
