using System;
using System.IO;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Threading;
using JetBrains.Annotations;

namespace ApesVSHeliumModLoader.Menus
{
    public partial class ModsMenu : UserControl
    {
        [CanBeNull] private Thread _startModSearchThread;
        [CanBeNull] public static Timer ModFolderSearchTimer;

        public ModsMenu()
        {
            InitializeComponent();
        }

        private void ModsMenu_Load(object sender, EventArgs e)
        {
            _startModSearchThread = new Thread(StartModSearchTimer) {IsBackground = true};
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
                if (ModLoaderForm.GamePath == "DefaultPath") return;
                ModsListBox.Items.Clear();
                foreach (var modFile in Directory.GetFiles($"{ModLoaderForm.GamePath}\\Mods"))
                {
                    var removePath = modFile.Remove(0, modFile.IndexOf(@"\Mods\") + 6);
                    ModsListBox.Items.Add(removePath);
                }
            }
            ModsListBox.Invoke((MethodInvoker) Mod);
        }

        private void InjectModButton_Click(object sender, EventArgs e)
        {
            var path = $"{ModLoaderForm.GamePath}\\Mods\\{ModsListBox.Text}";
            ModLoaderForm.Inject("Apes vs Helium", path, ModsListBox.Text.Remove(ModsListBox.Text.IndexOf(".dll"), 4), "Loader", "Load");
            MessageBox.Show(@"Injection Successful!");
        }
    }
}
