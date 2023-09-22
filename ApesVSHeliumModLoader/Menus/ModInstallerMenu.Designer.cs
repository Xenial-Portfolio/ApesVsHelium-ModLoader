
namespace ApesVSHeliumModLoader.Menus
{
    partial class ModInstallerMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InstallModLabel = new System.Windows.Forms.Label();
            this.InstallModButton = new System.Windows.Forms.Button();
            this.DownloadLinkTextBox = new System.Windows.Forms.TextBox();
            this.ModInstallerLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstallModLabel
            // 
            this.InstallModLabel.AutoSize = true;
            this.InstallModLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstallModLabel.ForeColor = System.Drawing.Color.White;
            this.InstallModLabel.Location = new System.Drawing.Point(13, 339);
            this.InstallModLabel.Name = "InstallModLabel";
            this.InstallModLabel.Size = new System.Drawing.Size(87, 21);
            this.InstallModLabel.TabIndex = 21;
            this.InstallModLabel.Text = "Install Mod";
            // 
            // InstallModButton
            // 
            this.InstallModButton.BackColor = System.Drawing.Color.White;
            this.InstallModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallModButton.Location = new System.Drawing.Point(17, 394);
            this.InstallModButton.Name = "InstallModButton";
            this.InstallModButton.Size = new System.Drawing.Size(361, 25);
            this.InstallModButton.TabIndex = 20;
            this.InstallModButton.Text = "Install Mod";
            this.InstallModButton.UseVisualStyleBackColor = false;
            this.InstallModButton.Click += new System.EventHandler(this.InstallModButton_Click);
            // 
            // DownloadLinkTextBox
            // 
            this.DownloadLinkTextBox.Location = new System.Drawing.Point(17, 363);
            this.DownloadLinkTextBox.Multiline = true;
            this.DownloadLinkTextBox.Name = "DownloadLinkTextBox";
            this.DownloadLinkTextBox.Size = new System.Drawing.Size(361, 25);
            this.DownloadLinkTextBox.TabIndex = 19;
            this.DownloadLinkTextBox.Text = "ex; www.dropbox.com/download";
            // 
            // ModInstallerLabel
            // 
            this.ModInstallerLabel.AutoSize = true;
            this.ModInstallerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModInstallerLabel.ForeColor = System.Drawing.Color.White;
            this.ModInstallerLabel.Location = new System.Drawing.Point(111, 5);
            this.ModInstallerLabel.Name = "ModInstallerLabel";
            this.ModInstallerLabel.Size = new System.Drawing.Size(173, 37);
            this.ModInstallerLabel.TabIndex = 18;
            this.ModInstallerLabel.Text = "Mod Installer";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.DarkRed;
            this.OutputTextBox.ForeColor = System.Drawing.Color.White;
            this.OutputTextBox.Location = new System.Drawing.Point(13, 45);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(361, 287);
            this.OutputTextBox.TabIndex = 22;
            this.OutputTextBox.TabStop = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputLabel.ForeColor = System.Drawing.Color.White;
            this.OutputLabel.Location = new System.Drawing.Point(10, 22);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(62, 21);
            this.OutputLabel.TabIndex = 23;
            this.OutputLabel.Text = "Output:";
            // 
            // ModInstallerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InstallModLabel);
            this.Controls.Add(this.InstallModButton);
            this.Controls.Add(this.DownloadLinkTextBox);
            this.Controls.Add(this.ModInstallerLabel);
            this.Name = "ModInstallerMenu";
            this.Size = new System.Drawing.Size(388, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstallModLabel;
        private System.Windows.Forms.Button InstallModButton;
        public System.Windows.Forms.TextBox DownloadLinkTextBox;
        private System.Windows.Forms.Label ModInstallerLabel;
        public System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label OutputLabel;
    }
}
