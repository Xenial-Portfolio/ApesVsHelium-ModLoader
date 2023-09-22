using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Threading;
using JetBrains.Annotations;

namespace ModdingPlatformBase
{
    public partial class MenuForm : Form
    {
        [CanBeNull] private Thread _startModSearchThread;
        [CanBeNull] public static Timer ModFolderSearchTimer;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            CreateAutoLoadConfig();
            _startModSearchThread = new Thread(StartModSearchTimer) { IsBackground = true };
            _startModSearchThread.Start();
        }

        private void StartModSearchTimer()
        {
            ModFolderSearchTimer = new Timer { Interval = 4500, Enabled = false };
            ModFolderSearchTimer.Elapsed += SearchModFolderTimer;
            ModFolderSearchTimer.AutoReset = true;
        }

        private void SearchModFolderTimer(object source, ElapsedEventArgs e)
        {
            void Mod()
            {
                ModListBox.Items.Clear();
                foreach (var modFile in Directory.GetFiles($"{Directory.GetCurrentDirectory()}\\Mods"))
                {
                    var removePath = modFile.Remove(0, modFile.IndexOf(@"\Mods\") + 6);
                    ModListBox.Items.Add(removePath);
                }
            }
            ModListBox.Invoke((MethodInvoker)Mod);
        }

        private void CreateAutoLoadConfig()
        {
            var path = $"{Directory.GetCurrentDirectory()}/AutoLoadMods/AutoLoadMods.txt";
            List<string> modsList = new List<string>();
            if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/AutoLoadMods")) Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/AutoLoadMods");
            if (!File.Exists(path)) File.WriteAllText(path, "");
        }

        private void UpdateAutoLoadConfig(string newFile, bool remove)
        {
            var path = $"{Directory.GetCurrentDirectory()}/AutoLoadMods/AutoLoadMods.txt";
            if (!File.Exists(path)) CreateAutoLoadConfig();
            var autoLoadMods = File.ReadAllLines(path).ToList();
            if (!remove && !autoLoadMods.Contains($"{newFile},")) autoLoadMods.Add($"{newFile},");
            if (remove) autoLoadMods.Remove($"{newFile},");
            File.WriteAllLines(path, autoLoadMods);
        }

        public void SaveSettings(string setting, string value)
        {
            List<string> settings = new List<string>();
            if (!File.Exists($"{Directory.GetCurrentDirectory()}/internalSettings.txt"))
                File.WriteAllText($"{Directory.GetCurrentDirectory()}/internalSettings.txt", "");
            else settings = File.ReadAllLines($"{Directory.GetCurrentDirectory()}/internalSettings.txt").ToList();

            switch (setting)
            {
                case "Auto-Load":
                    var autoLoadSetting = settings[settings.IndexOf("Auto-Load=")];
                    autoLoadSetting = autoLoadSetting.Remove(0, 10);
                    //settings[settings.IndexOf("Auto-Load={")] = ;
                    break;
            }

            //File.WriteAllText(Directory.GetCurrentDirectory());
        }
    }
}
