/* 
Mark Montenieri
MS539 - Fall 2022
Final Project - Character Configurator sandbox
Estimate - 55 hours Total
Nov 11 - 1hr 45m
Nov 13 - 3hr 
Nov 18 - 2hr
Nov 20 - 4.5hr
Nov 22 - 4hr
Nov 26 - 1 hr
Nov 27 3 hr
Nov 28 5 hr - UI Cleanup; Tabindex; 1st textbox focus on program start; Ensure summary text gets filled no matter how values are chosen
Nov 29 - 2 hr - Commenting and clarifying functionality; Removed unused code
Dec 8 - 1 hr


TODO: ( Responding to Live session critique)
1. Fix window size to show the background more effectively - Complete
2. Change transparency in control panels - too dark - Complete
3. Remove redundant intro text - Complete
4. Change "Start" to Login/Create and pass that data to configurator form

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
         
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();// Exit the program
        }
    }
}
