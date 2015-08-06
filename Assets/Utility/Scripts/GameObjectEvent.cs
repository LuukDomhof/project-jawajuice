using UnityEngine;

namespace Jawa.Utility
{
    public class GameObjectEvent
    {
        public GameObject GameObject;


        public GameObjectEvent(GameObject gameObject = null)
        {
            GameObject = gameObject;
        }
    }


    public class GameObjectEvent<TContent> : GameObjectEvent
    {
        public TContent Content;


        public GameObjectEvent(GameObject gameObject = null, TContent content = default(TContent))
            : base(gameObject)
        {
            Content = content;
        }
    }
}
