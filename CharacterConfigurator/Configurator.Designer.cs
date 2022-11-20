namespace CharacterConfigurator
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCharName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRandStats = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.textBoxStatStam = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBarStam = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose from the available options to create your character";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveConfig.Location = new System.Drawing.Point(796, 750);
            this.buttonSaveConfig.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(183, 75);
            this.buttonSaveConfig.TabIndex = 2;
            this.buttonSaveConfig.Text = "Save config";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character Name";
            // 
            // textBoxCharName
            // 
            this.textBoxCharName.Location = new System.Drawing.Point(8, 50);
            this.textBoxCharName.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxCharName.Name = "textBoxCharName";
            this.textBoxCharName.Size = new System.Drawing.Size(177, 26);
            this.textBoxCharName.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textBoxCharName);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(199, 174);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(19, 750);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(183, 75);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1565, 750);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(183, 75);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stats: 20 pts to spend";
            // 
            // buttonRandStats
            // 
            this.buttonRandStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandStats.Location = new System.Drawing.Point(59, 421);
            this.buttonRandStats.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRandStats.Name = "buttonRandStats";
            this.buttonRandStats.Size = new System.Drawing.Size(183, 75);
            this.buttonRandStats.TabIndex = 9;
            this.buttonRandStats.Text = "Randomize";
            this.buttonRandStats.UseVisualStyleBackColor = true;
            this.buttonRandStats.Click += new System.EventHandler(this.buttonRandStats_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.buttonRandStats);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(393, 82);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(534, 506);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel3.Controls.Add(this.trackBarStrength);
            this.flowLayoutPanel3.Controls.Add(this.textBoxStatStr);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // trackBarStrength
            // 
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
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel4.Controls.Add(this.trackBarInt);
            this.flowLayoutPanel4.Controls.Add(this.textBoxStatInt);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 210);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // trackBarInt
            // 
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
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.flowLayoutPanel5.Controls.Add(this.trackBarStam);
            this.flowLayoutPanel5.Controls.Add(this.textBoxStatStam);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 333);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(295, 75);
            this.flowLayoutPanel5.TabIndex = 11;
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
            // trackBarStam
            // 
            this.trackBarStam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarStam.LargeChange = 1;
            this.trackBarStam.Location = new System.Drawing.Point(3, 3);
            this.trackBarStam.Name = "trackBarStam";
            this.trackBarStam.Size = new System.Drawing.Size(227, 69);
            this.trackBarStam.TabIndex = 9;
            this.trackBarStam.Scroll += new System.EventHandler(this.trackBarStam_Scroll);
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 844);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.label1);
            this.Name = "Configurator";
            this.Text = "Configurator";
            this.Load += new System.EventHandler(this.Configurator_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCharName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRandStats;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
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
    }
}