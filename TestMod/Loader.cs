using JetBrains.Annotations;
using UnityEngine;

namespace TestMod
{
    class Loader : MonoBehaviour
    {
        [CanBeNull] public static GameObject _injectGameObject;

        public static void Load()
        {
            _injectGameObject = new GameObject();
            _injectGameObject.AddComponent<Main>();

            DontDestroyOnLoad(_injectGameObject);
        }

        public static void DestroyObject()
        {
            Destroy(_injectGameObject);
        }
    }
}
