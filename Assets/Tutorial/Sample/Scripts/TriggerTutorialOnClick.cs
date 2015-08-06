using Jawa.Utility;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Jawa.Tutorial.Sample
{
    public class TriggerTutorialOnClick : MonoBehaviour, IPointerClickHandler
    {
        public string TutorialEntryName;


        public void OnPointerClick(PointerEventData eventData)
        {
            EventAggregator.GetInstance().Trigger(new TutorialEvent(gameObject, TutorialEntryName));
        }
    }
}
