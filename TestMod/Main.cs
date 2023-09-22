using System;
using System.IO;
using UnityEngine;
using static TestMod.ModAPI.API;
using TestMod.ModAPI;
using TMPro;

namespace TestMod
{
    class Main : MonoBehaviour
    {
        public TextMeshPro textDisplay;

        private float _posX, _posY, _posZ;

        //private bool _fly, _crazyWeaponMode, _crazyWeaponSpeed;
        //private int _x = 50, _y = 80, _z, _index;
        private GameObject _mysteryBoxGameObject, _sceneDebuggerGameObject;

        public void Start()
        {
            if (!IsGameStarted()) return;
            SetCurrency(500);
            SetHealth(35);
            SetLastRound(1500);

            textDisplay = gameObject.AddComponent<TextMeshPro>();
            DontDestroyOnLoad(textDisplay);

            _sceneDebuggerGameObject = new GameObject();
            _sceneDebuggerGameObject.AddComponent<SceneDebugger>();
            DontDestroyOnLoad(_sceneDebuggerGameObject);

            CreateMysteryBox();
        }

        private void CreateMysteryBox()
        {
            _mysteryBoxGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _mysteryBoxGameObject.name = "MysteryBoxCube";
            _mysteryBoxGameObject.tag = "MysteryBox";
            _mysteryBoxGameObject.transform.localScale = new Vector3(5, 1.5f, 1.5f);
            _mysteryBoxGameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            _mysteryBoxGameObject.AddComponent<MysteryBoxScript>();
            DontDestroyOnLoad(_mysteryBoxGameObject);
        }

        public void Update()
        {
            _posX = FirstPersonControllerInstance.transform.position.x;
            _posY = FirstPersonControllerInstance.transform.position.y;
            _posZ = FirstPersonControllerInstance.transform.position.z;

            UpdatePosition();

            /* if (Input.GetKeyDown(KeyCode.Insert))
                 _fly = !_fly;*/

            /*if (_fly)
            {
                FirstPersonControllerInstance.transform.position = new Vector3(_x, _y, _z);
                if (Input.GetKey(KeyCode.W)) _z++;
                if (Input.GetKey(KeyCode.S)) _z--;

                if (Input.GetKey(KeyCode.A)) _x--;
                if (Input.GetKey(KeyCode.D)) _x++;
                
                if (Input.GetKey(KeyCode.UpArrow)) _y++;
                if (Input.GetKey(KeyCode.DownArrow)) _y--;
            }

            if (Input.GetKeyDown(KeyCode.Comma))
                _crazyWeaponMode = !_crazyWeaponMode;

            if (_crazyWeaponMode)
            {
                GetCurrentWeapon().anim.SetFloat("Speed", _crazyWeaponMode ? 1500 : 1);
                GetCurrentWeapon().spread = .1f;
                GetCurrentWeapon().projectilesPerShot = 150;
                GetCurrentWeapon().damage = 50;
            }

            if (Input.GetKeyDown(KeyCode.B))
                _crazyWeaponSpeed = !_crazyWeaponSpeed;

            if (_crazyWeaponSpeed)
            {
                GetCurrentWeapon().anim.SetFloat("Speed", _crazyWeaponSpeed ? 1500 : 1);
                GetCurrentWeapon().reloading = false;
            }

            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                if (_index == WeaponIds.WeaponsList.Count - 1) _index = 0;
                ChangeWeapon(WeaponIds.WeaponsList[_index++]);
            }*/
        }

        public void OnGUI()
        {
            //GUI.TextArea(new Rect(20, Screen.height / 2f, 150, 255), "Press (Insert) to enable fly mode\n\nPress < to enable crazy weapon mode (Warning cannot get any upgrades in shop)\n\nPress B to enable crazy weapon speed");
        }

        private void UpdatePosition()
        {
            var uiText = "Made By Xenial.-";

            textDisplay = FindObjectOfType<TextMeshPro>();
            textDisplay.transform.position = new Vector3(_posX, _posY + 10, _posZ + 15);
            textDisplay.autoSizeTextContainer = true;
            
            textDisplay.font = TMP_FontAsset.CreateFontAsset(new UnityEngine.Font("Arial"));
            textDisplay.fontSize = 15;
            textDisplay.color = UnityEngine.Color.blue;

            textDisplay.transform.LookAt(Camera.main.transform);
            textDisplay.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
            textDisplay.gameObject.transform.RotateAround(FirstPersonControllerInstance.transform.localPosition, Vector3.up, 0);

            textDisplay.gameObject.SetActive(false);
            textDisplay.SetText(uiText);
            textDisplay.gameObject.SetActive(true);
        }
    }
}