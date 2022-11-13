﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CharacterConfigurator
{
    public partial class Configurator : Form
    {
        private Form1 form1;// Declare Form1        

        public Configurator(Form1 form1)// Pass in Form1
        {
            this.form1 = form1;// Assign form1 that was passed in to field var
            InitializeComponent();
        }

        private void Configurator_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);// Center form on screen 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();// Closes the app entirely

            /* This fires for every open form - not cool */
            //base.OnFormClosing(e);

            //if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //// Confirm user wants to close
            //switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            //{
            //    case DialogResult.No:
            //        e.Cancel = true;
            //        break;
            //    case DialogResult.Yes:
            //        System.Windows.Forms.Application.Exit(e);
            //        break;
            //    default:
            //        break;
            //}
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            if (textBoxCharName.Text != "")// Has text?
            {
                StreamWriter sWriter = new StreamWriter(textBoxCharName.Text);// Init
                string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);// Set save dir
                strPath = strPath + "/Character Config.txt";// Set save file name

                using (sWriter = File.AppendText(strPath)) sWriter.Write(textBoxCharName.Text + Environment.NewLine);// Write text to file
                 
                sWriter.Close();// Close writer
                MessageBox.Show("Name saved!", "Success", MessageBoxButtons.OK);// Notify user
            }
            else
            {
                MessageBox.Show("Nothing to save. Please enter a character name.", "No data", MessageBoxButtons.OK);// Show error msg
            }           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();// Hide this form
            form1.Show(this);// Show form1
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();// Closes the app entirely
        }

        private void buttonRandStats_Click(object sender, EventArgs e)
        {
            /* Get random number between 10-20 */
            int randNum1 = GetRandNum(10, 20);
            int randNum2 = GetRandNum(10, 20);
            int randNum3 = GetRandNum(10, 20);

            int subTotal =  randNum1 + randNum2 + randNum3;
            int overage = 0;

            if (subTotal > 20)
            {
                overage = subTotal - 20;
            }

            int trimAmt = overage / 3;
            int remainder = overage % 3;

            randNum1 -= trimAmt;
            randNum2 -= trimAmt;
            randNum3 -= trimAmt;
            

        }

        private int GetRandNum(int r1, int r2)
        {
            Random random = new Random();// Declare
           int randNum = random.Next(10, 20);// Get rand in range

            return randNum;// Return int
        }       
    }
}
