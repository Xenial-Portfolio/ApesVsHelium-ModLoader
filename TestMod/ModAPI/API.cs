using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace TestMod.ModAPI
{
    public class API : MonoBehaviour
    {
        [CanBeNull] public static Currency CurrencyInstance = Currency.instance;
        [CanBeNull] public static PlayerHealth PlayerHealthInstance = PlayerHealth.instance;
        [CanBeNull] public static UpgradeScript UpgradeScriptInstance = UpgradeScript.instance;
        [CanBeNull] public static EquipmentScript EquipmentScriptInstance = EquipmentScript.instance;
        [CanBeNull] public static WaveSpawner WaveSpawnerInstance = FindObjectOfType<WaveSpawner>();
        [CanBeNull] public static GameManagerScript GameManagerInstance = Singleton<GameManagerScript>.instance;
        [CanBeNull] public static WaveSpawner.Wave WaveInstance;
        [CanBeNull] public static Enemy[] EnemyInstance = FindObjectsOfType<Enemy>();
        [CanBeNull] public static Weapon WeaponInstance = FindObjectOfType<Weapon>();
        [CanBeNull] public static WeaponMovement WeaponMovementInstance = FindObjectOfType<WeaponMovement>();
        [CanBeNull] public static FirstPersonController FirstPersonControllerInstance = FindObjectOfType<FirstPersonController>();
        [CanBeNull] public static RigidbodyFirstPersonController RigidbodyFirstPersonControllerInstance = FindObjectOfType<RigidbodyFirstPersonController>();

        public static void SetCurrency(int amount)
        {
            CurrencyInstance.currency = amount;
            CurrencyInstance.UpdateCurrency(0);
        }

        public static void UpdateCurrency(int amount)
        {
            CurrencyInstance.currency += amount;
            CurrencyInstance.UpdateCurrency(0);
        }

        public static void SetHealth(int amount)
        {
            PlayerHealthInstance.health = amount;
            PlayerHealthInstance.UpdateHealth(0);
        }

        public static void SetLastRound(int lastRound)
        {
            WaveSpawnerInstance.lastRound = lastRound;
            UpdateRoundText();
        }

        public static void SetRound(int round)
        {
            WaveSpawnerInstance.nextwave = round;
            UpdateRoundText();
        }

        private static void UpdateRoundText()
        {
            WaveSpawnerInstance.waveNumberText.text = (WaveSpawnerInstance.nextwave + 1).ToString() + "/" + (object)WaveSpawnerInstance.lastRound;
            WaveSpawnerInstance.waveNumberTextDefeat.text = "Round " + (WaveSpawnerInstance.nextwave + 1).ToString();
        }

        public static bool IsGameStarted()
        {
            return PlayerHealthInstance.gameObject != null;
        }

        public static void ChangeWeapon(string weaponId)
        {
            EquipmentScriptInstance.ChangeWeapon(weaponId);
        }

        public static void ChangeClass(string classId)
        {
            UpgradeScriptInstance.ChangeClass(classId);
        }

        public static Weapon GetCurrentWeapon()
        {
            return WeaponInstance = FindObjectOfType<Weapon>();
        }

        public static class WeaponIds
        {
            public static string DartMonkey = "Dart Monkey";
            public static string QuickShots = "Quick Shots";
            public static string SharpShots = "Sharp Shots";
            public static string Crossbow = "Crossbow";
            public static string SharpShooter = "Sharp Shooter";
            public static string CrossbowMaster = "Crossbow Master";
            public static string TripleShot = "Triple Shot";
            public static string MonkeyFanClub = "Monkey Fan Club";
            public static string SuperMonkeyFanClub = "Super Monkey Fan Club";
            public static string PlasmaMonkeyFanClub = "Plasma Monkey Fan Club";
            public static string DartlingGunner = "Dartling Gunner";
            public static string FocusedFiring = "Focused Firing";
            public static string FasterBarrelSpin = "Faster Barrel Spin";
            public static string PowerfulDarts = "Powerful Darts";
            public static string LaserCannon = "Laser Cannon";
            public static string Buckshot = "Buckshot";
            public static string HydraRocketPods = "Hydra Rocket Pods";
            public static string PlasmaAccelerator = "Plasma Accelerator";
            public static string BADGun = "BAD Gun";
            public static string RocketStorm = "Rocket Storm";
            public static string Boomerang = "Boomerang";
            public static string FasterThrowing = "Faster Throwing";
            public static string ImprovedRangs = "Improved Rangs";
            public static string Glaive = "Glaive";
            public static string BionicBoomerang = "Bionic Boomerang";
            public static string TurboCharge = "Turbo Charge";
            public static string PlasmaSword = "Plasma Sword";
            public static string PlasmaSwordMaster = "Plasma Sword Master";
            public static string SuperMonkey = "Super Monkey";
            public static string LaserVision = "Laser Vision";
            public static string PlasmaVision = "Plasma Vision";
            public static string RoboMonkey = "Robo Monkey";
            public static string SunAvatar = "Sun Avatar";
            public static string Ninja = "Ninja";
            public static string NinjaDiscipline = "Ninja Discipline";
            public static string SharpShurikens = "Sharp Shurikens";
            public static string DoubleShot = "Double Shot";
            public static string Bloonjitsu = "Bloonjitsu";
            public static string GrandmasterNinja = "Grandmaster Ninja";
            public static string Sniper = "Sniper";
            public static string FastFiring = "Fast Firing";
            public static string FullMetalJacket = "Full Metal Jacket";
            public static string EvenFasterFiring = "Even Faster Firing";
            public static string LargeCalibre = "Large Calibre";
            public static string DeadlyPrecision = "Deadly Precision";
            public static string MaimMOAB = "Maim MOAB";
            public static string CrippleMOAB = "Cripple MOAB";
            public static string SemiAutomatic = "Semi-Automatic";
            public static string FullAutoRifle = "Full Auto Rifle";
            public static string EliteDefender = "Elite Defender";
            public static string FlashBomb = "Flash Bomb";
            public static string StickyBomb = "Sticky Bomb";
            public static string MasterBomber = "Master Bomber";
            public static string PlasmaRangs = "Plasma Rangs";
            public static string PermaCharge = "Perma Charge";
            public static string SunGod = "Sun God";
            public static string TechnologicalTerror = "Technological Terror";
            public static string BloonHunter = "Bloon Hunter";
            public static string DarkLord = "Dark Lord";

            public static List<string> WeaponsList = new List<string>()
            {
                DartMonkey, QuickShots, SharpShots, Crossbow, SharpShooter, CrossbowMaster, TripleShot, MonkeyFanClub,
                SuperMonkeyFanClub, PlasmaMonkeyFanClub, DartlingGunner, FocusedFiring, FasterBarrelSpin, PowerfulDarts,
                LaserCannon, Buckshot, HydraRocketPods, PlasmaAccelerator, BADGun, RocketStorm, Boomerang,
                FasterThrowing, ImprovedRangs, Glaive, BionicBoomerang, TurboCharge, PlasmaSword, PlasmaSwordMaster,
                SuperMonkey, LaserVision, PlasmaVision, RoboMonkey, SunAvatar, Ninja, NinjaDiscipline, SharpShurikens,
                DoubleShot, Bloonjitsu, GrandmasterNinja, Sniper, FastFiring, FullMetalJacket, EvenFasterFiring,
                LargeCalibre, DeadlyPrecision, MaimMOAB, CrippleMOAB, SemiAutomatic, FullAutoRifle, EliteDefender,
                FlashBomb, StickyBomb, MasterBomber, PlasmaRangs, PermaCharge, SunGod, TechnologicalTerror, BloonHunter,
                DarkLord
            };
        }

        public static class MaterialCreator
        {
            public static Material GetMaterial(string path, int width, int height, string gameObjectName)
            {
                var selected = LoadImage(path, width, height);
                selected.name = gameObjectName;
                
                var material = new Material(Shader.Find("Unlit/Texture"))
                {
                    mainTexture = selected
                };

                return material;
            }

            public static Texture2D LoadImage(string filename, int width, int height)
            {
                var bytes = File.ReadAllBytes(filename);

                var texture = new Texture2D(width, height);
                texture.LoadImage(bytes);

                return texture;
            }
        }
    }
}
