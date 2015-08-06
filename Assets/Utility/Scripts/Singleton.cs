using UnityEngine;

namespace Jawa.Utility
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _instance;


        private void OnDestroy()
        {
            _instance = null;            
        }


        public static T GetInstance()
        {
            if (_instance == null)
            {
                _instance = Object.FindObjectOfType<T>();

                if (_instance == null)
                {
                    _instance = new GameObject(typeof(T).Name).AddComponent<T>();
                }
            }

            return _instance;
        }
    }
}
