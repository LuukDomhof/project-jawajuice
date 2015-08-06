using System;
using System.Collections.Generic;

namespace Jawa.Utility
{
    public class EventAggregator : Singleton<EventAggregator>
    {
        public delegate void GameObjectEventHandler<TEvent>(TEvent e) where TEvent : GameObjectEvent;


        private IDictionary<Type, IList<object>> _handlersByEventType;


        private void Awake()
        {
            _handlersByEventType = new Dictionary<Type, IList<object>>();
        }


        public void Trigger<TEvent>(TEvent e) where TEvent : GameObjectEvent
        {
            IList<object> handlers;

            if (_handlersByEventType.TryGetValue(e.GetType(), out handlers))
            {
                for (var i = handlers.Count - 1; i >= 0; --i)
                {
                    var handler = (GameObjectEventHandler<TEvent>)handlers[i];

                    handler(e);
                }
            }
        }

        public void On<TEvent>(GameObjectEventHandler<TEvent> handler) where TEvent : GameObjectEvent
        {
            var eventType = typeof(TEvent);

            IList<object> handlers;

            if (!_handlersByEventType.TryGetValue(eventType, out handlers))
            {
                handlers = new List<object>();

                _handlersByEventType[eventType] = handlers;
            }

            handlers.Add(handler);
        }
    }
}
