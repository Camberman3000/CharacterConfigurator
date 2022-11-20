/* 
Mark Montenieri
MS539 - Fall 2022
Final Project - Character Configurator sandbox
Estimate - 55 hours Total
Nov 11 - 1hr 45m
Nov 13 - 3hr 
Nov 18 - 2hr
Nov 20 - 4hr
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
        private Configurator configuratorForm;// Declare configurator form

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
            if (configuratorForm != null)
            {
               // Don't create, it already exists
            }
            else
            {
                configuratorForm = new Configurator(this);// Create new configurator form
            }
           
            configuratorForm.Show();// Show configurator form
            this.Hide();// Hide this form
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
