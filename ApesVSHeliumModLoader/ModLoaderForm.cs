using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ApesVSHeliumModLoader.AVH;
using ApesVSHeliumModLoader.Menus;
using ApesVSHeliumModLoader.MonoInjector;
using JetBrains.Annotations;

namespace ApesVSHeliumModLoader
{
    public partial class ModLoaderForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WmNclButtonDown = 0xA1, HtCaption = 0x2;

        [CanBeNull] public static Injector Injector;
        [CanBeNull] public static string GamePath, GameSavePath;
        [CanBeNull] public ConfigHandler _configHandler = new ConfigHandler();

        private static ModLoaderForm _instance;
        public static ModLoaderForm GetInstance()
        {
            var form = _instance;
            if (form != null)
            {
                return form;
            }
            return (_instance = new ModLoaderForm());
        }

        public ModLoaderForm()
        {
            InitializeComponent();
            _configHandler.CreateConfig();
        }

        public static void Inject(string gameName, string modDLLPath, string @namespace, string className, string methodName)
        {
            var asm = File.ReadAllBytes(modDLLPath);
            Injector = new Injector(gameName);
            Injector.Inject(asm, @namespace, className, methodName);
        }

        private void Eject(IntPtr assembly, string @namespace, string className, string methodName)
        {
            Injector.Eject(assembly, @namespace, className, methodName);
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            Inject("Apes vs Helium", ModDLLPath.Text, NameSpaceTextBox.Text, ClassNameTextBox.Text, MethodNameTextBox.Text);
        }

        private void InstallModButton_Click(object sender, EventArgs e)
        {
            MenuController(3);
        }

        private void ModsButton_Click(object sender, EventArgs e)
        {
            MenuController(2);
        }

        private void LocationMenuControl_Load(object sender, EventArgs e)
        {
            HideAllMenus();
            PathMenuControl.GameLocationTextBox.Text = GamePath;
        }

        public void HideAllMenus()
        {
            PathMenuControl.Hide();
            ModsMenuControl.Hide();
            ModInstallerMenu.Hide();
            ModsMenu.ModFolderSearchTimer.Enabled = false;
        }

        public void MenuController(int menu)
        {
            HideAllMenus();
            switch (menu)
            {
                case 1:
                    PathMenuControl.Show();
                    PathMenuControl.BringToFront();
                    break;
                case 2:
                    ModsMenuControl.Show();
                    ModsMenuControl.BringToFront();
                    ModsMenu.ModFolderSearchTimer.Enabled = true;
                    break;
                case 3:
                    ModInstallerMenu.Show();
                    ModInstallerMenu.BringToFront();
                    break;
            }
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
        }

        private void BTDModLauncherLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            MenuController(1);
        }

        private void InjectorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitlePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}