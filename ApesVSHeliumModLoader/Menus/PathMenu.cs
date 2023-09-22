using System;
using System.IO;
using System.Windows.Forms;

namespace ApesVSHeliumModLoader.Menus
{
    public partial class PathMenu : UserControl
    {
        public PathMenu()
        {
            InitializeComponent();
        }

        private void SetGamePathButton_Click(object sender, EventArgs e)
        {
            OpenSaveFileDialog.Multiselect = false;
            OpenSaveFileDialog.ShowDialog();
        }

        private void PathMenu_Load(object sender, EventArgs e)
        {
            ModLoaderForm.GetInstance()._configHandler.ReadConfig();
        }

        private void OpenSaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ModLoaderForm.GamePath = OpenSaveFileDialog.FileName;
            GameLocationTextBox.Text = ModLoaderForm.GamePath = ModLoaderForm.GamePath.Remove(ModLoaderForm.GamePath.IndexOf(@"\Apes vs Helium.exe"), 19);

            var path = $"{GameLocationTextBox.Text}\\Mods";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Directory.CreateDirectory($@"{path}\Textures");
            }
            ModLoaderForm.GetInstance()._configHandler.UpdateOption("GamePath");
        }
    }
}
