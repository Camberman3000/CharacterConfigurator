﻿namespace CharacterConfigurator
{
    partial class Configurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurator));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCharFirstName = new System.Windows.Forms.TextBox();
            this.flp_Bio = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCharLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxHometown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCharClass = new System.Windows.Forms.ComboBox();
            this.buttonRandomizeBio = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRandStats = new System.Windows.Forms.Button();
            this.flp_Stats = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.textBoxStatStr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarInt = new System.Windows.Forms.TrackBar();
            this.textBoxStatInt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarStam = new System.Windows.Forms.TrackBar();
            this.textBoxStatStam = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSummaryCharName = new System.Windows.Forms.TextBox();
            this.flp_Summary = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_Name = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxHomeTown = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCharClass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Humanoid = new System.Windows.Forms.RadioButton();
            this.rb_Creature = new System.Windows.Forms.RadioButton();
            this.flp_Bio.SuspendLayout();
            this.flp_Stats.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStam)).BeginInit();
            this.flp_Summary.SuspendLayout();
            this.flp_Name.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose from the available options to create your character";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveConfig.Location = new System.Drawing.Point(796, 750);
            this.buttonSaveConfig.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(183, 75);
            this.buttonSaveConfig.TabIndex = 2;
            this.buttonSaveConfig.Text = "Save config";
            this.buttonSaveConfig.UseVisualStyleBackColor = false;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 770);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save current character configuration to file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCharFirstName
            // 
            this.textBoxCharFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCharFirstName.Location = new System.Drawing.Point(3, 35);
            this.textBoxCharFirstName.Name = "textBoxCharFirstName";
            this.textBoxCharFirstName.Size = new System.Drawing.Size(220, 26);
            this.textBoxCharFirstName.TabIndex = 5;
            // 
            // flp_Bio
            // 
            this.flp_Bio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Bio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flp_Bio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Bio.Controls.Add(this.label3);
            this.flp_Bio.Controls.Add(this.textBoxCharFirstName);
            this.flp_Bio.Controls.Add(this.label10);
            this.flp_Bio.Controls.Add(this.textBoxCharLastName);
            this.flp_Bio.Controls.Add(this.label8);
            this.flp_Bio.Controls.Add(this.comboBoxHometown);
            this.flp_Bio.Controls.Add(this.label9);
            this.flp_Bio.Controls.Add(this.comboBoxCharClass);
            this.flp_Bio.Controls.Add(this.label15);
            this.flp_Bio.Controls.Add(this.groupBox1);
            this.flp_Bio.Controls.Add(this.buttonRandomizeBio);
            this.flp_Bio.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Bio.Location = new System.Drawing.Point(150, 82);
            this.flp_Bio.Name = "flp_Bio";
            this.flp_Bio.Size = new System.Drawing.Size(230, 546);
            this.flp_Bio.TabIndex = 6;
            this.flp_Bio.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Bio_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(3, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Character Last Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCharLastName
            // 
            this.textBoxCharLastName.Location = new System.Drawing.Point(3, 99);
            this.textBoxCharLastName.Name = "textBoxCharLastName";
            this.textBoxCharLastName.Size = new System.Drawing.Size(220, 26);
            this.textBoxCharLastName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Character Hometown";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxHometown
            // 
            this.comboBoxHometown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxHometown.FormattingEnabled = true;
            this.comboBoxHometown.Location = new System.Drawing.Point(3, 163);
            this.comboBoxHometown.Name = "comboBoxHometown";
            this.comboBoxHometown.Size = new System.Drawing.Size(220, 28);
            this.comboBoxHometown.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Character Class";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCharClass
            // 
            this.comboBoxCharClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCharClass.FormattingEnabled = true;
            this.comboBoxCharClass.Location = new System.Drawing.Point(3, 229);
            this.comboBoxCharClass.Name = "comboBoxCharClass";
            this.comboBoxCharClass.Size = new System.Drawing.Size(220, 28);
            this.comboBoxCharClass.TabIndex = 9;
            // 
            // buttonRandomizeBio
            // 
            this.buttonRandomizeBio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandomizeBio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRandomizeBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomizeBio.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRandomizeBio.Location = new System.Drawing.Point(21, 408);
            this.buttonRandomizeBio.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRandomizeBio.Name = "buttonRandomizeBio";
            this.buttonRandomizeBio.Size = new System.Drawing.Size(183, 75);
            this.buttonRandomizeBio.TabIndex = 15;
            this.buttonRandomizeBio.Text = "Randomize";
            this.buttonRandomizeBio.UseVisualStyleBackColor = false;
            this.buttonRandomizeBio.Click += new System.EventHandler(this.buttonRandomizeBio_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(19, 750);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(183, 75);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(1565, 750);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(183, 75);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(25, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stats: 20 points to spend";
            // 
            // buttonRandStats
            // 
            this.buttonRandStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandStats.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRandStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandStats.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRandStats.Location = new System.Drawing.Point(59, 421);
            this.buttonRandStats.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRandStats.Name = "buttonRandStats";
            this.buttonRandStats.Size = new System.Drawing.Size(183, 75);
            this.buttonRandStats.TabIndex = 9;
            this.buttonRandStats.Text = "Randomize";
            this.buttonRandStats.UseVisualStyleBackColor = false;
            this.buttonRandStats.Click += new System.EventHandler(this.buttonRandStats_Click);
            // 
            // flp_Stats
            // 
            this.flp_Stats.AutoSize = true;
            this.flp_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flp_Stats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Stats.Controls.Add(this.label4);
            this.flp_Stats.Controls.Add(this.label5);
            this.flp_Stats.Controls.Add(this.flowLayoutPanel3);
            this.flp_Stats.Controls.Add(this.label6);
            this.flp_Stats.Controls.Add(this.flowLayoutPanel4);
            this.flp_Stats.Controls.Add(this.label7);
            this.flp_Stats.Controls.Add(this.flowLayoutPanel5);
            this.flp_Stats.Controls.Add(this.buttonRandStats);
            this.flp_Stats.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Stats.Location = new System.Drawing.Point(393, 82);
            this.flp_Stats.Name = "flp_Stats";
            this.flp_Stats.Size = new System.Drawing.Size(305, 510);
            this.flp_Stats.TabIndex = 7;
            this.flp_Stats.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Stats_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(103, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Strength";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel3.Controls.Add(this.trackBarStrength);
            this.flowLayoutPanel3.Controls.Add(this.textBoxStatStr);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // trackBarStrength
            // 
            this.trackBarStrength.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarStrength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarStrength.LargeChange = 1;
            this.trackBarStrength.Location = new System.Drawing.Point(3, 3);
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(227, 69);
            this.trackBarStrength.TabIndex = 9;
            this.trackBarStrength.Scroll += new System.EventHandler(this.trackBarStrength_Scroll);
            // 
            // textBoxStatStr
            // 
            this.textBoxStatStr.Location = new System.Drawing.Point(236, 3);
            this.textBoxStatStr.Name = "textBoxStatStr";
            this.textBoxStatStr.ReadOnly = true;
            this.textBoxStatStr.Size = new System.Drawing.Size(56, 26);
            this.textBoxStatStr.TabIndex = 10;
            this.textBoxStatStr.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(89, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Intelligence";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel4.Controls.Add(this.trackBarInt);
            this.flowLayoutPanel4.Controls.Add(this.textBoxStatInt);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 210);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // trackBarInt
            // 
            this.trackBarInt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarInt.LargeChange = 1;
            this.trackBarInt.Location = new System.Drawing.Point(3, 3);
            this.trackBarInt.Name = "trackBarInt";
            this.trackBarInt.Size = new System.Drawing.Size(227, 69);
            this.trackBarInt.TabIndex = 9;
            this.trackBarInt.Scroll += new System.EventHandler(this.trackBarInt_Scroll);
            // 
            // textBoxStatInt
            // 
            this.textBoxStatInt.Location = new System.Drawing.Point(236, 3);
            this.textBoxStatInt.Name = "textBoxStatInt";
            this.textBoxStatInt.ReadOnly = true;
            this.textBoxStatInt.Size = new System.Drawing.Size(56, 26);
            this.textBoxStatInt.TabIndex = 10;
            this.textBoxStatInt.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(104, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stamina";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel5.Controls.Add(this.trackBarStam);
            this.flowLayoutPanel5.Controls.Add(this.textBoxStatStam);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 333);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // trackBarStam
            // 
            this.trackBarStam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBarStam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarStam.LargeChange = 1;
            this.trackBarStam.Location = new System.Drawing.Point(3, 3);
            this.trackBarStam.Name = "trackBarStam";
            this.trackBarStam.Size = new System.Drawing.Size(227, 69);
            this.trackBarStam.TabIndex = 9;
            this.trackBarStam.Scroll += new System.EventHandler(this.trackBarStam_Scroll);
            // 
            // textBoxStatStam
            // 
            this.textBoxStatStam.Location = new System.Drawing.Point(236, 3);
            this.textBoxStatStam.Name = "textBoxStatStam";
            this.textBoxStatStam.ReadOnly = true;
            this.textBoxStatStam.Size = new System.Drawing.Size(56, 26);
            this.textBoxStatStam.TabIndex = 10;
            this.textBoxStatStam.Text = "0";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(1314, 115);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel6.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(449, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "Summary";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSummaryCharName
            // 
            this.textBoxSummaryCharName.Location = new System.Drawing.Point(80, 3);
            this.textBoxSummaryCharName.Name = "textBoxSummaryCharName";
            this.textBoxSummaryCharName.ReadOnly = true;
            this.textBoxSummaryCharName.Size = new System.Drawing.Size(235, 26);
            this.textBoxSummaryCharName.TabIndex = 18;
            // 
            // flp_Summary
            // 
            this.flp_Summary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Summary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flp_Summary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flp_Summary.Controls.Add(this.label11);
            this.flp_Summary.Controls.Add(this.flp_Name);
            this.flp_Summary.Controls.Add(this.flowLayoutPanel7);
            this.flp_Summary.Controls.Add(this.flowLayoutPanel8);
            this.flp_Summary.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Summary.Location = new System.Drawing.Point(1193, 82);
            this.flp_Summary.Name = "flp_Summary";
            this.flp_Summary.Size = new System.Drawing.Size(454, 416);
            this.flp_Summary.TabIndex = 19;
            this.flp_Summary.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Summary_Paint);
            // 
            // flp_Name
            // 
            this.flp_Name.AutoSize = true;
            this.flp_Name.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flp_Name.Controls.Add(this.label12);
            this.flp_Name.Controls.Add(this.textBoxSummaryCharName);
            this.flp_Name.Location = new System.Drawing.Point(3, 35);
            this.flp_Name.Name = "flp_Name";
            this.flp_Name.Size = new System.Drawing.Size(318, 32);
            this.flp_Name.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(762, 46);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 75);
            this.button1.TabIndex = 15;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonRandomizeBio_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1231, 630);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 21;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel7.Controls.Add(this.label13);
            this.flowLayoutPanel7.Controls.Add(this.textBoxHomeTown);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(364, 32);
            this.flowLayoutPanel7.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = "Hometown";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHomeTown
            // 
            this.textBoxHomeTown.Location = new System.Drawing.Point(126, 3);
            this.textBoxHomeTown.Name = "textBoxHomeTown";
            this.textBoxHomeTown.ReadOnly = true;
            this.textBoxHomeTown.Size = new System.Drawing.Size(235, 26);
            this.textBoxHomeTown.TabIndex = 19;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel8.Controls.Add(this.label14);
            this.flowLayoutPanel8.Controls.Add(this.textBoxCharClass);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 111);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(430, 89);
            this.flowLayoutPanel8.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 26);
            this.label14.TabIndex = 19;
            this.label14.Text = "Character Class";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCharClass
            // 
            this.textBoxCharClass.Location = new System.Drawing.Point(177, 3);
            this.textBoxCharClass.Name = "textBoxCharClass";
            this.textBoxCharClass.ReadOnly = true;
            this.textBoxCharClass.Size = new System.Drawing.Size(235, 26);
            this.textBoxCharClass.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(3, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 26);
            this.label15.TabIndex = 16;
            this.label15.Text = "*Character Race";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Creature);
            this.groupBox1.Controls.Add(this.rb_Humanoid);
            this.groupBox1.Location = new System.Drawing.Point(3, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rb_Humanoid
            // 
            this.rb_Humanoid.AutoSize = true;
            this.rb_Humanoid.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_Humanoid.Location = new System.Drawing.Point(18, 25);
            this.rb_Humanoid.Name = "rb_Humanoid";
            this.rb_Humanoid.Size = new System.Drawing.Size(107, 24);
            this.rb_Humanoid.TabIndex = 0;
            this.rb_Humanoid.TabStop = true;
            this.rb_Humanoid.Text = "Humanoid";
            this.rb_Humanoid.UseVisualStyleBackColor = true;
            this.rb_Humanoid.CheckedChanged += new System.EventHandler(this.rb_Humanoid_CheckedChanged);
            // 
            // rb_Creature
            // 
            this.rb_Creature.AutoSize = true;
            this.rb_Creature.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_Creature.Location = new System.Drawing.Point(18, 55);
            this.rb_Creature.Name = "rb_Creature";
            this.rb_Creature.Size = new System.Drawing.Size(96, 24);
            this.rb_Creature.TabIndex = 1;
            this.rb_Creature.TabStop = true;
            this.rb_Creature.Text = "Creature";
            this.rb_Creature.UseVisualStyleBackColor = true;
            this.rb_Creature.CheckedChanged += new System.EventHandler(this.rb_Creature_CheckedChanged);
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1778, 844);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flp_Summary);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.flp_Stats);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flp_Bio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveConfig);
            this.Name = "Configurator";
            this.Text = "Configurator";
            this.Load += new System.EventHandler(this.Configurator_Load);
            this.flp_Bio.ResumeLayout(false);
            this.flp_Bio.PerformLayout();
            this.flp_Stats.ResumeLayout(false);
            this.flp_Stats.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStam)).EndInit();
            this.flp_Summary.ResumeLayout(false);
            this.flp_Summary.PerformLayout();
            this.flp_Name.ResumeLayout(false);
            this.flp_Name.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCharFirstName;
        private System.Windows.Forms.FlowLayoutPanel flp_Bio;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRandStats;
        private System.Windows.Forms.FlowLayoutPanel flp_Stats;
        private System.Windows.Forms.TrackBar trackBarStrength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxStatStr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TrackBar trackBarInt;
        private System.Windows.Forms.TextBox textBoxStatInt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxStatStam;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TrackBar trackBarStam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxHometown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCharClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCharLastName;
        private System.Windows.Forms.Button buttonRandomizeBio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSummaryCharName;
        private System.Windows.Forms.FlowLayoutPanel flp_Summary;
        private System.Windows.Forms.FlowLayoutPanel flp_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxHomeTown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCharClass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Creature;
        private System.Windows.Forms.RadioButton rb_Humanoid;
    }
}