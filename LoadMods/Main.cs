using System;
using System.IO;
using LoadMods.ModAPI;
using UnityEngine;
using TMPro;

namespace LoadMods
{
    class Main : MonoBehaviour
    {
        private GameObject  _sceneDebuggerGameObject;

        public void Start()
        {
            _sceneDebuggerGameObject = new GameObject();
            _sceneDebuggerGameObject.AddComponent<SceneDebugger>();
            DontDestroyOnLoad(_sceneDebuggerGameObject);
        }

    }
}