
namespace ApesVSHeliumModLoader.Menus
{
    partial class ModsMenu
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
            this.ModsLabel = new System.Windows.Forms.Label();
            this.ModsListBox = new System.Windows.Forms.ListBox();
            this.InjectModButton = new System.Windows.Forms.Button();
            this.AutoInjectLabel = new System.Windows.Forms.Label();
            this.AutoInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ModsLabel
            // 
            this.ModsLabel.AutoSize = true;
            this.ModsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModsLabel.ForeColor = System.Drawing.Color.White;
            this.ModsLabel.Location = new System.Drawing.Point(117, 13);
            this.ModsLabel.Name = "ModsLabel";
            this.ModsLabel.Size = new System.Drawing.Size(159, 37);
            this.ModsLabel.TabIndex = 1;
            this.ModsLabel.Text = "Mods Menu";
            // 
            // ModsListBox
            // 
            this.ModsListBox.BackColor = System.Drawing.Color.Maroon;
            this.ModsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModsListBox.ForeColor = System.Drawing.Color.White;
            this.ModsListBox.FormattingEnabled = true;
            this.ModsListBox.ItemHeight = 15;
            this.ModsListBox.Location = new System.Drawing.Point(3, 53);
            this.ModsListBox.Name = "ModsListBox";
            this.ModsListBox.Size = new System.Drawing.Size(388, 317);
            this.ModsListBox.TabIndex = 2;
            // 
            // InjectModButton
            // 
            this.InjectModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectModButton.ForeColor = System.Drawing.Color.White;
            this.InjectModButton.Location = new System.Drawing.Point(3, 398);
            this.InjectModButton.Name = "InjectModButton";
            this.InjectModButton.Size = new System.Drawing.Size(388, 35);
            this.InjectModButton.TabIndex = 11;
            this.InjectModButton.Text = "Inject Mod";
            this.InjectModButton.UseVisualStyleBackColor = true;
            this.InjectModButton.Click += new System.EventHandler(this.InjectModButton_Click);
            // 
            // AutoInjectLabel
            // 
            this.AutoInjectLabel.AutoSize = true;
            this.AutoInjectLabel.ForeColor = System.Drawing.Color.White;
            this.AutoInjectLabel.Location = new System.Drawing.Point(2, 377);
            this.AutoInjectLabel.Name = "AutoInjectLabel";
            this.AutoInjectLabel.Size = new System.Drawing.Size(104, 15);
            this.AutoInjectLabel.TabIndex = 12;
            this.AutoInjectLabel.Text = "Auto Inject Mods: ";
            // 
            // AutoInjectCheckBox
            // 
            this.AutoInjectCheckBox.AutoSize = true;
            this.AutoInjectCheckBox.Location = new System.Drawing.Point(101, 379);
            this.AutoInjectCheckBox.Name = "AutoInjectCheckBox";
            this.AutoInjectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AutoInjectCheckBox.TabIndex = 13;
            this.AutoInjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.AutoInjectCheckBox);
            this.Controls.Add(this.AutoInjectLabel);
            this.Controls.Add(this.InjectModButton);
            this.Controls.Add(this.ModsListBox);
            this.Controls.Add(this.ModsLabel);
            this.Name = "ModsMenu";
            this.Size = new System.Drawing.Size(394, 436);
            this.Load += new System.EventHandler(this.ModsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModsLabel;
        public System.Windows.Forms.ListBox ModsListBox;
        private System.Windows.Forms.Button InjectModButton;
        private System.Windows.Forms.Label AutoInjectLabel;
        private System.Windows.Forms.CheckBox AutoInjectCheckBox;
    }
}
