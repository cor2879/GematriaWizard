namespace GematriaWizard.Forms
{
    partial class Wizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleGematriaValueLabel = new System.Windows.Forms.Label();
            this.englishGematriaValueLabel = new System.Windows.Forms.Label();
            this.hebrewGematriaValueLabel = new System.Windows.Forms.Label();
            this.simpleGematriaLabel = new System.Windows.Forms.Label();
            this.englishGematriaLabel = new System.Windows.Forms.Label();
            this.hebrewGematriaLabel = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.simpleGematriaValueLabel);
            this.panel1.Controls.Add(this.englishGematriaValueLabel);
            this.panel1.Controls.Add(this.hebrewGematriaValueLabel);
            this.panel1.Controls.Add(this.simpleGematriaLabel);
            this.panel1.Controls.Add(this.englishGematriaLabel);
            this.panel1.Controls.Add(this.hebrewGematriaLabel);
            this.panel1.Location = new System.Drawing.Point(12, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 132);
            this.panel1.TabIndex = 3;
            // 
            // simpleGematriaValueLabel
            // 
            this.simpleGematriaValueLabel.AutoSize = true;
            this.simpleGematriaValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simpleGematriaValueLabel.Location = new System.Drawing.Point(126, 60);
            this.simpleGematriaValueLabel.Name = "simpleGematriaValueLabel";
            this.simpleGematriaValueLabel.Size = new System.Drawing.Size(14, 15);
            this.simpleGematriaValueLabel.TabIndex = 5;
            this.simpleGematriaValueLabel.Tag = "simple";
            this.simpleGematriaValueLabel.Text = "h";
            // 
            // englishGematriaValueLabel
            // 
            this.englishGematriaValueLabel.AutoSize = true;
            this.englishGematriaValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishGematriaValueLabel.Location = new System.Drawing.Point(126, 35);
            this.englishGematriaValueLabel.Name = "englishGematriaValueLabel";
            this.englishGematriaValueLabel.Size = new System.Drawing.Size(14, 15);
            this.englishGematriaValueLabel.TabIndex = 4;
            this.englishGematriaValueLabel.Tag = "english";
            this.englishGematriaValueLabel.Text = "h";
            // 
            // hebrewGematriaValueLabel
            // 
            this.hebrewGematriaValueLabel.AutoSize = true;
            this.hebrewGematriaValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hebrewGematriaValueLabel.Location = new System.Drawing.Point(126, 10);
            this.hebrewGematriaValueLabel.Name = "hebrewGematriaValueLabel";
            this.hebrewGematriaValueLabel.Size = new System.Drawing.Size(14, 15);
            this.hebrewGematriaValueLabel.TabIndex = 3;
            this.hebrewGematriaValueLabel.Tag = "hebrew";
            this.hebrewGematriaValueLabel.Text = "h";
            // 
            // simpleGematriaLabel
            // 
            this.simpleGematriaLabel.AutoSize = true;
            this.simpleGematriaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simpleGematriaLabel.Location = new System.Drawing.Point(10, 60);
            this.simpleGematriaLabel.Name = "simpleGematriaLabel";
            this.simpleGematriaLabel.Size = new System.Drawing.Size(103, 15);
            this.simpleGematriaLabel.TabIndex = 2;
            this.simpleGematriaLabel.Text = "Simple Gematria:";
            this.simpleGematriaLabel.Visible = false;
            // 
            // englishGematriaLabel
            // 
            this.englishGematriaLabel.AutoSize = true;
            this.englishGematriaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishGematriaLabel.Location = new System.Drawing.Point(10, 35);
            this.englishGematriaLabel.Name = "englishGematriaLabel";
            this.englishGematriaLabel.Size = new System.Drawing.Size(103, 15);
            this.englishGematriaLabel.TabIndex = 1;
            this.englishGematriaLabel.Text = "English Gematria:";
            this.englishGematriaLabel.Visible = false;
            // 
            // hebrewGematriaLabel
            // 
            this.hebrewGematriaLabel.AutoSize = true;
            this.hebrewGematriaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hebrewGematriaLabel.Location = new System.Drawing.Point(10, 10);
            this.hebrewGematriaLabel.Name = "hebrewGematriaLabel";
            this.hebrewGematriaLabel.Size = new System.Drawing.Size(110, 15);
            this.hebrewGematriaLabel.TabIndex = 0;
            this.hebrewGematriaLabel.Text = "Hebrew Gematria:";
            this.hebrewGematriaLabel.Visible = false;
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.mainTextBox);
            this.InputPanel.Location = new System.Drawing.Point(12, 73);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(776, 131);
            this.InputPanel.TabIndex = 2;
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(3, 3);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.PlaceholderText = "Enter phrase";
            this.mainTextBox.Size = new System.Drawing.Size(768, 123);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Wizard";
            this.Text = "Gematria Wizard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label simpleGematriaValueLabel;
        private Label englishGematriaValueLabel;
        private Label hebrewGematriaValueLabel;
        private Label simpleGematriaLabel;
        private Label englishGematriaLabel;
        private Label hebrewGematriaLabel;
        private Panel InputPanel;
        private TextBox mainTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}