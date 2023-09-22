using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using static TestMod.ModAPI.API;
using Random = System.Random;

namespace TestMod.ModAPI
{
    public class MysteryBoxScript : MonoBehaviour
    {
        private Ray _ray;
        private RaycastHit _hit;
        private bool _isInteractable, _isItemTaken = true, _isItemInQueue;
        private Camera _camera;
        private readonly Random _randomWeapon = new Random();
        private string _interactiveOutput, _item, _output;
        private int _dist;

        private List<string> _highChanceList = new List<string>()
        {
            WeaponIds.DartMonkey, WeaponIds.Crossbow, WeaponIds.DartlingGunner, WeaponIds.SuperMonkey, WeaponIds.Ninja,
            WeaponIds.Sniper, WeaponIds.Buckshot, WeaponIds.Boomerang
        };

        private List<string> _normalChanceList = new List<string>()
        {
            WeaponIds.QuickShots, WeaponIds.SharpShots, WeaponIds.SharpShooter, WeaponIds.MonkeyFanClub,
            WeaponIds.FocusedFiring, WeaponIds.FasterBarrelSpin, WeaponIds.PowerfulDarts, WeaponIds.FasterThrowing, WeaponIds.ImprovedRangs,
            WeaponIds.LaserVision, WeaponIds.NinjaDiscipline, WeaponIds.SharpShurikens, WeaponIds.DoubleShot, WeaponIds.FastFiring, WeaponIds.FullMetalJacket, WeaponIds.EvenFasterFiring
        };

        private List<string> _lowChanceList = new List<string>()
        {
            WeaponIds.CrossbowMaster, WeaponIds.TripleShot, WeaponIds.SuperMonkeyFanClub, WeaponIds.PlasmaMonkeyFanClub, WeaponIds.LaserCannon,
            WeaponIds.HydraRocketPods, WeaponIds.PlasmaAccelerator, WeaponIds.BADGun, WeaponIds.RocketStorm, WeaponIds.Glaive, WeaponIds.BionicBoomerang,
            WeaponIds.TurboCharge, WeaponIds.PlasmaSword, WeaponIds.PlasmaSwordMaster, WeaponIds.RoboMonkey, WeaponIds.SunAvatar, WeaponIds.Bloonjitsu,
            WeaponIds.GrandmasterNinja, WeaponIds.LargeCalibre, WeaponIds.DeadlyPrecision, WeaponIds.MaimMOAB, WeaponIds.CrippleMOAB, WeaponIds.SemiAutomatic,
            WeaponIds.FullAutoRifle, WeaponIds.EliteDefender, WeaponIds.MasterBomber, WeaponIds.PlasmaRangs, WeaponIds.PermaCharge, WeaponIds.SunGod, WeaponIds.TechnologicalTerror,
            WeaponIds.BloonHunter, WeaponIds.DarkLord, WeaponIds.PlasmaVision, WeaponIds.SemiAutomatic, WeaponIds.FlashBomb, WeaponIds.StickyBomb
        };

        public void Start()
        {
            _camera = Camera.main;

            transform.Rotate(new Vector3(0f, -50f, 0), Space.Self);
            var renderer = GetComponent<Renderer>();
            var normalMaterial = MaterialCreator.LoadImage($@"{Directory.GetCurrentDirectory()}\Mods\Textures\MysteryBoxTextureNormal.jpg", 2, 2);

            renderer.material.EnableKeyword("_NORMALMAP");
            renderer.material.SetTexture("_BumpMap", normalMaterial);

            gameObject.transform.GetComponent<MeshRenderer>().material = MaterialCreator.GetMaterial($@"{Directory.GetCurrentDirectory()}\Mods\Textures\MysteryBoxTexture.jpg", 2, 2, "MysteryBoxTexture");

            var shop = GameObject.Find("Shop");
            transform.position = new Vector3(shop.transform.position.x, shop.transform.position.y, shop.transform.position.z);
            shop.SetActive(false);

            var island = GameObject.Find("Island");
            island.SetActive(true);

            var sellUpgrades = island.transform.root.Find("Sell Upgrades");
            sellUpgrades.gameObject.SetActive(true);

            var oldUpgrades = island.transform.root.Find("Old Upgrades");
            oldUpgrades.gameObject.SetActive(true);

            var regrowBlocker = island.transform.root.Find("Regrow Blocker");
            regrowBlocker.gameObject.SetActive(true);

            var camoDetection = island.transform.root.Find("Camo Detection");
            camoDetection.gameObject.SetActive(true);

            var ninja = oldUpgrades.transform.Find("Ninja");
            ninja.gameObject.SetActive(true);

            var sharpShots = oldUpgrades.transform.Find("Sharp Shots");
            sharpShots.gameObject.SetActive(true);

            var boomerang = oldUpgrades.transform.Find("Boomerang");
            boomerang.gameObject.SetActive(true);

            var dartlingGun = oldUpgrades.transform.Find("Dartling Gun");
            dartlingGun.gameObject.SetActive(true);

            var superMonkey = oldUpgrades.transform.Find("Super Monkey");
            superMonkey.gameObject.SetActive(true);
        }

        public void Update()
        {
            _dist = (int)Math.Ceiling(Vector3.Distance(_camera.transform.position, gameObject.transform.position));
            if (_dist > 8) return;

            _ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(_ray, out _hit)) return;
            
            if (_hit.transform.gameObject.name == "MysteryBoxCube")
            {
                _isInteractable = true;
                if (Input.GetKeyDown(KeyCode.F)) Interact();
            }

            if (_hit.transform.gameObject.name != "MysteryBoxCube")
                _isInteractable = false;
        }

        public virtual void Interact()
        {
            if (CurrencyInstance.currency < 950 && !_isItemInQueue) return;
            if (!_isItemInQueue)
            {
                _isItemTaken = false;
                RandomizeWeapon();

                _isItemInQueue = true;
                UpdateCurrency(-950);
                return;
            }

            if (_isItemInQueue && !_isItemTaken && Input.GetKeyDown(KeyCode.F))
            {
                _isItemTaken = true;
                _isItemInQueue = false;

                if (_item != GetCurrentWeapon().name)
                {
                    ChangeWeapon(_item);
                    return;
                }

                RandomizeWeapon();
                ChangeWeapon(_item);
            }
        }

        private void RandomizeWeapon()
        {
            var chance = Chance();
            switch (chance)
            {
                case 0.5f:
                    _item = _highChanceList[_randomWeapon.Next(0, _highChanceList.Count)];
                    break;
                case 0.3f:
                    _item = _normalChanceList[_randomWeapon.Next(0, _normalChanceList.Count)];
                    break;
                case 0.1f:
                    _item = _lowChanceList[_randomWeapon.Next(0, _lowChanceList.Count)];
                    break;
            }
            _interactiveOutput = $"Take: {_item}";
        }

        public void OnGUI()
        {
            if (_dist > 8) return;
            if (!_isItemInQueue && _isItemTaken)
                _interactiveOutput = "Press F - $950";

            if (_isInteractable)
                GUI.Label(new Rect(Screen.width / 2f, Screen.height / 2.5f, 150f, 150f), _interactiveOutput);
        }

        public float Chance()
        {
            float[] chances = { 0.5f, 0.3f, 0.1f };

            var randValue = UnityEngine.Random.value;
            var currentChance = 0f;

            float minChanceRange;
            float maxChanceRange;

            for (var i = 0; i < chances.Length; i++)
            {
                currentChance += chances[i];

                minChanceRange = 0.5f - currentChance / 2;
                maxChanceRange = 0.5f + currentChance / 2;

                if (randValue >= minChanceRange && randValue <= maxChanceRange)
                    return chances[i];
            }

            return -1;
        }
    }
}