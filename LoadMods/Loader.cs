using JetBrains.Annotations;
using System.Reflection;
using UnityEngine;

namespace LoadMods
{
    class Loader : MonoBehaviour
    {
        [CanBeNull] public static GameObject _injectGameObject;

        public static void Load()
        {
            _injectGameObject = new GameObject();
            _injectGameObject.AddComponent<Main>();

            DontDestroyOnLoad(_injectGameObject);

            var data = System.IO.File.ReadAllBytes(@"C:\Users\david\Desktop\Apes vs Helium\Mods\TestMod.dll");
            Assembly.Load(data);
        }

        public static void DestroyObject()
        {
            Destroy(_injectGameObject);
        }
    }
}
