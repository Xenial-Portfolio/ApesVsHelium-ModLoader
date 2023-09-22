
namespace ApesVSHeliumModLoader
{
    partial class ModLoaderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModLoaderForm));
            this.ModDLLPath = new System.Windows.Forms.TextBox();
            this.NameSpaceTextBox = new System.Windows.Forms.TextBox();
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.MethodNameTextBox = new System.Windows.Forms.TextBox();
            this.InjectButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.BTDModLauncherLabel = new System.Windows.Forms.Label();
            this.InjectorPanel = new System.Windows.Forms.Panel();
            this.InjectorPanelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ModInstallerMenu = new ApesVSHeliumModLoader.Menus.ModInstallerMenu();
            this.ModsMenuControl = new ApesVSHeliumModLoader.Menus.ModsMenu();
            this.PathMenuControl = new ApesVSHeliumModLoader.Menus.PathMenu();
            this.ModInstallerButton = new System.Windows.Forms.Button();
            this.MenuOptionsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LocationButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ModsButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            this.InjectorPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModDLLPath
            // 
            this.ModDLLPath.Location = new System.Drawing.Point(4, 39);
            this.ModDLLPath.Name = "ModDLLPath";
            this.ModDLLPath.Size = new System.Drawing.Size(158, 23);
            this.ModDLLPath.TabIndex = 1;
            this.ModDLLPath.Text = "Mod DLL Path";
            // 
            // NameSpaceTextBox
            // 
            this.NameSpaceTextBox.Location = new System.Drawing.Point(4, 68);
            this.NameSpaceTextBox.Name = "NameSpaceTextBox";
            this.NameSpaceTextBox.Size = new System.Drawing.Size(158, 23);
            this.NameSpaceTextBox.TabIndex = 2;
            this.NameSpaceTextBox.Text = "NameSpace";
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Location = new System.Drawing.Point(4, 97);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(158, 23);
            this.ClassNameTextBox.TabIndex = 3;
            this.ClassNameTextBox.Text = "ClassName";
            // 
            // MethodNameTextBox
            // 
            this.MethodNameTextBox.Location = new System.Drawing.Point(4, 126);
            this.MethodNameTextBox.Name = "MethodNameTextBox";
            this.MethodNameTextBox.Size = new System.Drawing.Size(158, 23);
            this.MethodNameTextBox.TabIndex = 4;
            this.MethodNameTextBox.Text = "MethodName";
            // 
            // InjectButton
            // 
            this.InjectButton.BackColor = System.Drawing.Color.White;
            this.InjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectButton.Location = new System.Drawing.Point(4, 155);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(158, 23);
            this.InjectButton.TabIndex = 5;
            this.InjectButton.Text = "Inject Mod";
            this.InjectButton.UseVisualStyleBackColor = false;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Red;
            this.HeaderPanel.Controls.Add(this.TitlePictureBox);
            this.HeaderPanel.Controls.Add(this.MinimizeLabel);
            this.HeaderPanel.Controls.Add(this.ExitLabel);
            this.HeaderPanel.Controls.Add(this.BTDModLauncherLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(0, -67);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(609, 100);
            this.HeaderPanel.TabIndex = 6;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TitlePictureBox.Image")));
            this.TitlePictureBox.Location = new System.Drawing.Point(6, 67);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(27, 33);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePictureBox.TabIndex = 9;
            this.TitlePictureBox.TabStop = false;
            this.TitlePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePictureBox_MouseDown);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeLabel.ForeColor = System.Drawing.Color.White;
            this.MinimizeLabel.Location = new System.Drawing.Point(548, 64);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(24, 32);
            this.MinimizeLabel.TabIndex = 2;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(572, 66);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(28, 32);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // BTDModLauncherLabel
            // 
            this.BTDModLauncherLabel.AutoSize = true;
            this.BTDModLauncherLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTDModLauncherLabel.ForeColor = System.Drawing.Color.White;
            this.BTDModLauncherLabel.Location = new System.Drawing.Point(32, 67);
            this.BTDModLauncherLabel.Name = "BTDModLauncherLabel";
            this.BTDModLauncherLabel.Size = new System.Drawing.Size(205, 30);
            this.BTDModLauncherLabel.TabIndex = 0;
            this.BTDModLauncherLabel.Text = "AVH Mod Launcher";
            this.BTDModLauncherLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTDModLauncherLabel_MouseDown);
            // 
            // InjectorPanel
            // 
            this.InjectorPanel.BackColor = System.Drawing.Color.Maroon;
            this.InjectorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InjectorPanel.Controls.Add(this.InjectorPanelLabel);
            this.InjectorPanel.Controls.Add(this.ModDLLPath);
            this.InjectorPanel.Controls.Add(this.InjectButton);
            this.InjectorPanel.Controls.Add(this.NameSpaceTextBox);
            this.InjectorPanel.Controls.Add(this.MethodNameTextBox);
            this.InjectorPanel.Controls.Add(this.ClassNameTextBox);
            this.InjectorPanel.Location = new System.Drawing.Point(12, 39);
            this.InjectorPanel.Name = "InjectorPanel";
            this.InjectorPanel.Size = new System.Drawing.Size(168, 196);
            this.InjectorPanel.TabIndex = 7;
            this.InjectorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InjectorPanel_Paint);
            // 
            // InjectorPanelLabel
            // 
            this.InjectorPanelLabel.AutoSize = true;
            this.InjectorPanelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InjectorPanelLabel.ForeColor = System.Drawing.Color.White;
            this.InjectorPanelLabel.Location = new System.Drawing.Point(31, 5);
            this.InjectorPanelLabel.Name = "InjectorPanelLabel";
            this.InjectorPanelLabel.Size = new System.Drawing.Size(103, 21);
            this.InjectorPanelLabel.TabIndex = 6;
            this.InjectorPanelLabel.Text = "Injector Panel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ModInstallerMenu);
            this.panel3.Controls.Add(this.ModsMenuControl);
            this.panel3.Controls.Add(this.PathMenuControl);
            this.panel3.Location = new System.Drawing.Point(195, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 436);
            this.panel3.TabIndex = 8;
            // 
            // ModInstallerMenu
            // 
            this.ModInstallerMenu.BackColor = System.Drawing.Color.Maroon;
            this.ModInstallerMenu.Location = new System.Drawing.Point(-1, -1);
            this.ModInstallerMenu.Name = "ModInstallerMenu";
            this.ModInstallerMenu.Size = new System.Drawing.Size(394, 436);
            this.ModInstallerMenu.TabIndex = 9;
            // 
            // ModsMenuControl
            // 
            this.ModsMenuControl.BackColor = System.Drawing.Color.Maroon;
            this.ModsMenuControl.Location = new System.Drawing.Point(-1, -1);
            this.ModsMenuControl.Name = "ModsMenuControl";
            this.ModsMenuControl.Size = new System.Drawing.Size(394, 436);
            this.ModsMenuControl.TabIndex = 1;
            // 
            // PathMenuControl
            // 
            this.PathMenuControl.BackColor = System.Drawing.Color.Maroon;
            this.PathMenuControl.Location = new System.Drawing.Point(-1, 3);
            this.PathMenuControl.Name = "PathMenuControl";
            this.PathMenuControl.Size = new System.Drawing.Size(392, 430);
            this.PathMenuControl.TabIndex = 0;
            this.PathMenuControl.Load += new System.EventHandler(this.LocationMenuControl_Load);
            // 
            // ModInstallerButton
            // 
            this.ModInstallerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModInstallerButton.ForeColor = System.Drawing.Color.White;
            this.ModInstallerButton.Location = new System.Drawing.Point(6, 72);
            this.ModInstallerButton.Name = "ModInstallerButton";
            this.ModInstallerButton.Size = new System.Drawing.Size(155, 29);
            this.ModInstallerButton.TabIndex = 9;
            this.ModInstallerButton.Text = "Mod Installer";
            this.ModInstallerButton.UseVisualStyleBackColor = true;
            this.ModInstallerButton.Click += new System.EventHandler(this.InstallModButton_Click);
            // 
            // MenuOptionsLabel
            // 
            this.MenuOptionsLabel.AutoSize = true;
            this.MenuOptionsLabel.BackColor = System.Drawing.Color.Maroon;
            this.MenuOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.MenuOptionsLabel.Location = new System.Drawing.Point(43, 264);
            this.MenuOptionsLabel.Name = "MenuOptionsLabel";
            this.MenuOptionsLabel.Size = new System.Drawing.Size(109, 21);
            this.MenuOptionsLabel.TabIndex = 7;
            this.MenuOptionsLabel.Text = "Menu Options";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LocationButton);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ModsButton);
            this.panel1.Controls.Add(this.ModInstallerButton);
            this.panel1.Location = new System.Drawing.Point(12, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 217);
            this.panel1.TabIndex = 8;
            // 
            // LocationButton
            // 
            this.LocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationButton.ForeColor = System.Drawing.Color.White;
            this.LocationButton.Location = new System.Drawing.Point(6, 177);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(155, 29);
            this.LocationButton.TabIndex = 13;
            this.LocationButton.Text = "Path Settings";
            this.LocationButton.UseVisualStyleBackColor = true;
            this.LocationButton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Coming Soon!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Coming Soon!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ModsButton
            // 
            this.ModsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModsButton.ForeColor = System.Drawing.Color.White;
            this.ModsButton.Location = new System.Drawing.Point(6, 37);
            this.ModsButton.Name = "ModsButton";
            this.ModsButton.Size = new System.Drawing.Size(155, 29);
            this.ModsButton.TabIndex = 10;
            this.ModsButton.Text = "Mods";
            this.ModsButton.UseVisualStyleBackColor = true;
            this.ModsButton.Click += new System.EventHandler(this.ModsButton_Click);
            // 
            // ModLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(601, 487);
            this.Controls.Add(this.MenuOptionsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.InjectorPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModLoaderForm";
            this.Text = "ModLauncherForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            this.InjectorPanel.ResumeLayout(false);
            this.InjectorPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ModDLLPath;
        private System.Windows.Forms.TextBox NameSpaceTextBox;
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.TextBox MethodNameTextBox;
        private System.Windows.Forms.Button InjectButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label BTDModLauncherLabel;
        private System.Windows.Forms.Panel InjectorPanel;
        private System.Windows.Forms.Label InjectorPanelLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ModInstallerButton;
        private System.Windows.Forms.Label MenuOptionsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LocationButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ModsButton;
        private System.Windows.Forms.PictureBox TitlePictureBox;
        public Menus.PathMenu PathMenuControl;
        private Menus.ModsMenu ModsMenuControl;
        private Menus.ModInstallerMenu ModInstallerMenu;
    }
}

