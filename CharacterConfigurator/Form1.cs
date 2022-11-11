/* 
Mark Montenieri
MS539 - Fall 2022
Final Project - Character Configurator sandbox
Nov 13 estimate - 6 hours
Actual time - 7:30AM - 
 
 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterConfigurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {             
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);// Center form on screen          
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Configurator configuratorForm = new Configurator();
            configuratorForm.Show();
            this.Hide();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();// Exit the program
        }
    }
}
