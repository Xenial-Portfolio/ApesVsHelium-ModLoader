
namespace ModdingPlatformBase
{
    partial class MenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ModHeaderLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ModListBox = new System.Windows.Forms.ListBox();
            this.ModsListLabel = new System.Windows.Forms.Label();
            this.ModSettingsPanel = new System.Windows.Forms.Panel();
            this.SetAsDependencyCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoLoadModsCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateSettingsButton = new System.Windows.Forms.Button();
            this.ModSettingsLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.ModSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Red;
            this.HeaderPanel.Controls.Add(this.ModHeaderLabel);
            this.HeaderPanel.Controls.Add(this.CloseLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-3, -1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(807, 33);
            this.HeaderPanel.TabIndex = 0;
            // 
            // ModHeaderLabel
            // 
            this.ModHeaderLabel.AutoSize = true;
            this.ModHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.ModHeaderLabel.Location = new System.Drawing.Point(4, 6);
            this.ModHeaderLabel.Name = "ModHeaderLabel";
            this.ModHeaderLabel.Size = new System.Drawing.Size(159, 20);
            this.ModHeaderLabel.TabIndex = 1;
            this.ModHeaderLabel.Text = "Internal Mod Menu";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(779, 6);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(20, 20);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            // 
            // ModListBox
            // 
            this.ModListBox.BackColor = System.Drawing.Color.Maroon;
            this.ModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModListBox.ForeColor = System.Drawing.Color.White;
            this.ModListBox.FormattingEnabled = true;
            this.ModListBox.ItemHeight = 20;
            this.ModListBox.Location = new System.Drawing.Point(12, 70);
            this.ModListBox.Name = "ModListBox";
            this.ModListBox.Size = new System.Drawing.Size(240, 362);
            this.ModListBox.TabIndex = 1;
            // 
            // ModsListLabel
            // 
            this.ModsListLabel.AutoSize = true;
            this.ModsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModsListLabel.ForeColor = System.Drawing.Color.White;
            this.ModsListLabel.Location = new System.Drawing.Point(79, 47);
            this.ModsListLabel.Name = "ModsListLabel";
            this.ModsListLabel.Size = new System.Drawing.Size(86, 20);
            this.ModsListLabel.TabIndex = 2;
            this.ModsListLabel.Text = "Mods List";
            // 
            // ModSettingsPanel
            // 
            this.ModSettingsPanel.BackColor = System.Drawing.Color.Maroon;
            this.ModSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModSettingsPanel.Controls.Add(this.SetAsDependencyCheckBox);
            this.ModSettingsPanel.Controls.Add(this.AutoLoadModsCheckBox);
            this.ModSettingsPanel.Controls.Add(this.UpdateSettingsButton);
            this.ModSettingsPanel.Location = new System.Drawing.Point(258, 70);
            this.ModSettingsPanel.Name = "ModSettingsPanel";
            this.ModSettingsPanel.Size = new System.Drawing.Size(530, 364);
            this.ModSettingsPanel.TabIndex = 3;
            // 
            // SetAsDependencyCheckBox
            // 
            this.SetAsDependencyCheckBox.AutoSize = true;
            this.SetAsDependencyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAsDependencyCheckBox.ForeColor = System.Drawing.Color.White;
            this.SetAsDependencyCheckBox.Location = new System.Drawing.Point(157, 299);
            this.SetAsDependencyCheckBox.Name = "SetAsDependencyCheckBox";
            this.SetAsDependencyCheckBox.Size = new System.Drawing.Size(156, 22);
            this.SetAsDependencyCheckBox.TabIndex = 2;
            this.SetAsDependencyCheckBox.Text = "Set As Dependency";
            this.SetAsDependencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoLoadModsCheckBox
            // 
            this.AutoLoadModsCheckBox.AutoSize = true;
            this.AutoLoadModsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLoadModsCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoLoadModsCheckBox.Location = new System.Drawing.Point(14, 299);
            this.AutoLoadModsCheckBox.Name = "AutoLoadModsCheckBox";
            this.AutoLoadModsCheckBox.Size = new System.Drawing.Size(137, 22);
            this.AutoLoadModsCheckBox.TabIndex = 1;
            this.AutoLoadModsCheckBox.Text = "Auto-Load Mods";
            this.AutoLoadModsCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateSettingsButton
            // 
            this.UpdateSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UpdateSettingsButton.Location = new System.Drawing.Point(13, 322);
            this.UpdateSettingsButton.Name = "UpdateSettingsButton";
            this.UpdateSettingsButton.Size = new System.Drawing.Size(504, 27);
            this.UpdateSettingsButton.TabIndex = 0;
            this.UpdateSettingsButton.Text = "Update Settings";
            this.UpdateSettingsButton.UseVisualStyleBackColor = true;
            // 
            // ModSettingsLabel
            // 
            this.ModSettingsLabel.AutoSize = true;
            this.ModSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModSettingsLabel.ForeColor = System.Drawing.Color.White;
            this.ModSettingsLabel.Location = new System.Drawing.Point(469, 46);
            this.ModSettingsLabel.Name = "ModSettingsLabel";
            this.ModSettingsLabel.Size = new System.Drawing.Size(115, 20);
            this.ModSettingsLabel.TabIndex = 4;
            this.ModSettingsLabel.Text = "Mod Settings";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModSettingsLabel);
            this.Controls.Add(this.ModSettingsPanel);
            this.Controls.Add(this.ModsListLabel);
            this.Controls.Add(this.ModListBox);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "Internal Mod Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ModSettingsPanel.ResumeLayout(false);
            this.ModSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label ModHeaderLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.ListBox ModListBox;
        private System.Windows.Forms.Label ModsListLabel;
        private System.Windows.Forms.Panel ModSettingsPanel;
        private System.Windows.Forms.CheckBox AutoLoadModsCheckBox;
        private System.Windows.Forms.Button UpdateSettingsButton;
        private System.Windows.Forms.Label ModSettingsLabel;
        private System.Windows.Forms.CheckBox SetAsDependencyCheckBox;
    }
}