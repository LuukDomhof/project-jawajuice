using Jawa.Utility;
using UnityEngine;
using UnityEngine.UI;

namespace Jawa.Tutorial
{
    public class TutorialManager : MonoBehaviour
    {
        public TutorialData TutorialData;

        public Text TutorialText;


        private int _currentEntryIndex;


        private void Start()
        {
            TutorialText.text = TutorialData.Entries[0].Text;

            EventAggregator.GetInstance().On<TutorialEvent>(e =>
            {
                var nextEntryIndex = Mathf.Min(_currentEntryIndex + 1, TutorialData.Entries.Length - 1);

                if (e.TutorialEntryName == TutorialData.Entries[nextEntryIndex].Name)
                {
                    _currentEntryIndex = nextEntryIndex;
                }

                TutorialText.text = TutorialData.Entries[_currentEntryIndex].Text;
            });
        }
    }
}

