using UnityEngine;

namespace UdemyProject1.Abstracts.Utilities
{
    public abstract class SingletonObject<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }
        protected void SingLetonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
