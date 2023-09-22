using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using ModdingPlatformBase.Classes;
using UnityEngine;

namespace ModdingPlatformBase
{
    class Loader : MonoBehaviour
    {
        [CanBeNull] public static GameObject _injectGameObject;

        public static void Load()
        {
            _injectGameObject = new GameObject();
            _injectGameObject.AddComponent<Menu>();

            DontDestroyOnLoad(_injectGameObject);
        }

        public static void DestroyObject()
        {
            Destroy(_injectGameObject);
        }
    }
}
