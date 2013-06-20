﻿namespace AnimalCrossingQR
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromQRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternPanel = new System.Windows.Forms.Panel();
            this.editColorsButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.authorNameText = new System.Windows.Forms.TextBox();
            this.authorTownLabel = new System.Windows.Forms.Label();
            this.authorTownText = new System.Windows.Forms.TextBox();
            this.authorUniqueIDLabel = new System.Windows.Forms.Label();
            this.authorUniqueIDText = new System.Windows.Forms.MaskedTextBox();
            this.imageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.setDefaultButton = new System.Windows.Forms.Button();
            this.loadDefaultButton = new System.Windows.Forms.Button();
            this.helpBox = new System.Windows.Forms.PictureBox();
            this.paletteControl = new AnimalCrossingQR.PaletteControl();
            this.createQRButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(847, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatternToolStripMenuItem,
            this.openPatternToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPatternToolStripMenuItem
            // 
            this.newPatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankToolStripMenuItem,
            this.fromImageToolStripMenuItem});
            this.newPatternToolStripMenuItem.Name = "newPatternToolStripMenuItem";
            this.newPatternToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newPatternToolStripMenuItem.Text = "New Pattern";
            // 
            // blankToolStripMenuItem
            // 
            this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
            this.blankToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.blankToolStripMenuItem.Text = "Blank";
            this.blankToolStripMenuItem.Click += new System.EventHandler(this.blankToolStripMenuItem_Click);
            // 
            // fromImageToolStripMenuItem
            // 
            this.fromImageToolStripMenuItem.Name = "fromImageToolStripMenuItem";
            this.fromImageToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fromImageToolStripMenuItem.Text = "From Image...";
            this.fromImageToolStripMenuItem.Click += new System.EventHandler(this.fromImageToolStripMenuItem_Click);
            // 
            // openPatternToolStripMenuItem
            // 
            this.openPatternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromQRCodeToolStripMenuItem});
            this.openPatternToolStripMenuItem.Name = "openPatternToolStripMenuItem";
            this.openPatternToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openPatternToolStripMenuItem.Text = "Open Pattern";
            // 
            // fromQRCodeToolStripMenuItem
            // 
            this.fromQRCodeToolStripMenuItem.Name = "fromQRCodeToolStripMenuItem";
            this.fromQRCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromQRCodeToolStripMenuItem.Text = "From QR Code";
            this.fromQRCodeToolStripMenuItem.Click += new System.EventHandler(this.fromQRCodeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patternPanel
            // 
            this.patternPanel.Location = new System.Drawing.Point(95, 27);
            this.patternPanel.Name = "patternPanel";
            this.patternPanel.Size = new System.Drawing.Size(512, 512);
            this.patternPanel.TabIndex = 1;
            // 
            // editColorsButton
            // 
            this.editColorsButton.Location = new System.Drawing.Point(12, 341);
            this.editColorsButton.Name = "editColorsButton";
            this.editColorsButton.Size = new System.Drawing.Size(60, 29);
            this.editColorsButton.TabIndex = 3;
            this.editColorsButton.Text = "Edit";
            this.editColorsButton.UseVisualStyleBackColor = true;
            this.editColorsButton.Click += new System.EventHandler(this.editColorsButton_Click);
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.titleText.Location = new System.Drawing.Point(632, 57);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(197, 20);
            this.titleText.TabIndex = 4;
            this.titleText.Text = "Untitled";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(629, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(629, 92);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(69, 13);
            this.authorNameLabel.TabIndex = 7;
            this.authorNameLabel.Text = "Author Name";
            // 
            // authorNameText
            // 
            this.authorNameText.Location = new System.Drawing.Point(632, 108);
            this.authorNameText.Name = "authorNameText";
            this.authorNameText.Size = new System.Drawing.Size(197, 20);
            this.authorNameText.TabIndex = 6;
            // 
            // authorTownLabel
            // 
            this.authorTownLabel.AutoSize = true;
            this.authorTownLabel.Location = new System.Drawing.Point(629, 131);
            this.authorTownLabel.Name = "authorTownLabel";
            this.authorTownLabel.Size = new System.Drawing.Size(68, 13);
            this.authorTownLabel.TabIndex = 9;
            this.authorTownLabel.Text = "Author Town";
            // 
            // authorTownText
            // 
            this.authorTownText.Location = new System.Drawing.Point(632, 147);
            this.authorTownText.Name = "authorTownText";
            this.authorTownText.Size = new System.Drawing.Size(197, 20);
            this.authorTownText.TabIndex = 8;
            // 
            // authorUniqueIDLabel
            // 
            this.authorUniqueIDLabel.AutoSize = true;
            this.authorUniqueIDLabel.Location = new System.Drawing.Point(629, 170);
            this.authorUniqueIDLabel.Name = "authorUniqueIDLabel";
            this.authorUniqueIDLabel.Size = new System.Drawing.Size(89, 13);
            this.authorUniqueIDLabel.TabIndex = 11;
            this.authorUniqueIDLabel.Text = "Author Unique ID";
            // 
            // authorUniqueIDText
            // 
            this.authorUniqueIDText.Location = new System.Drawing.Point(632, 186);
            this.authorUniqueIDText.Mask = ">AA:AA:AA:AA:AA:AA";
            this.authorUniqueIDText.Name = "authorUniqueIDText";
            this.authorUniqueIDText.PromptChar = ' ';
            this.authorUniqueIDText.Size = new System.Drawing.Size(171, 20);
            this.authorUniqueIDText.TabIndex = 12;
            // 
            // imageOpenFileDialog
            // 
            this.imageOpenFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All files (*.*)|*" +
    ".*";
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.Location = new System.Drawing.Point(639, 212);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(89, 29);
            this.setDefaultButton.TabIndex = 13;
            this.setDefaultButton.Text = "Set as default";
            this.setDefaultButton.UseVisualStyleBackColor = true;
            this.setDefaultButton.Click += new System.EventHandler(this.setDefaultButton_Click);
            // 
            // loadDefaultButton
            // 
            this.loadDefaultButton.Location = new System.Drawing.Point(734, 212);
            this.loadDefaultButton.Name = "loadDefaultButton";
            this.loadDefaultButton.Size = new System.Drawing.Size(87, 29);
            this.loadDefaultButton.TabIndex = 14;
            this.loadDefaultButton.Text = "Load default";
            this.loadDefaultButton.UseVisualStyleBackColor = true;
            this.loadDefaultButton.Click += new System.EventHandler(this.loadDefaultButton_Click);
            // 
            // helpBox
            // 
            this.helpBox.Image = ((System.Drawing.Image)(resources.GetObject("helpBox.Image")));
            this.helpBox.Location = new System.Drawing.Point(809, 186);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(20, 20);
            this.helpBox.TabIndex = 15;
            this.helpBox.TabStop = false;
            this.helpBox.Click += new System.EventHandler(this.helpBox_Click);
            // 
            // paletteControl
            // 
            this.paletteControl.Location = new System.Drawing.Point(12, 27);
            this.paletteControl.Name = "paletteControl";
            this.paletteControl.SelectedIndex = -1;
            this.paletteControl.SelectedItem = -1;
            this.paletteControl.Size = new System.Drawing.Size(77, 308);
            this.paletteControl.TabIndex = 2;
            // 
            // createQRButton
            // 
            this.createQRButton.Location = new System.Drawing.Point(672, 275);
            this.createQRButton.Name = "createQRButton";
            this.createQRButton.Size = new System.Drawing.Size(116, 29);
            this.createQRButton.TabIndex = 16;
            this.createQRButton.Text = "Create QR Code";
            this.createQRButton.UseVisualStyleBackColor = true;
            this.createQRButton.Click += new System.EventHandler(this.createQRButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 559);
            this.Controls.Add(this.createQRButton);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.loadDefaultButton);
            this.Controls.Add(this.setDefaultButton);
            this.Controls.Add(this.authorUniqueIDText);
            this.Controls.Add(this.authorUniqueIDLabel);
            this.Controls.Add(this.authorTownLabel);
            this.Controls.Add(this.authorTownText);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.authorNameText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.editColorsButton);
            this.Controls.Add(this.paletteControl);
            this.Controls.Add(this.patternPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Animal Crossing QR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromQRCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel patternPanel;
        private PaletteControl paletteControl;
        private System.Windows.Forms.Button editColorsButton;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.TextBox authorNameText;
        private System.Windows.Forms.Label authorTownLabel;
        private System.Windows.Forms.TextBox authorTownText;
        private System.Windows.Forms.Label authorUniqueIDLabel;
        private System.Windows.Forms.MaskedTextBox authorUniqueIDText;
        private System.Windows.Forms.OpenFileDialog imageOpenFileDialog;
        private System.Windows.Forms.Button setDefaultButton;
        private System.Windows.Forms.Button loadDefaultButton;
        private System.Windows.Forms.PictureBox helpBox;
        private System.Windows.Forms.Button createQRButton;

    }
}

