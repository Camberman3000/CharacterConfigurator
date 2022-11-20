using System;
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

            /* Add text directly to combobox */
            comboBoxHometown.Items.Add("Deep Glen");
            comboBoxHometown.Items.Add("Rocky Nock");
            comboBoxHometown.Items.Add("Hill Valley");

            /* Add combobox text via array index */
            string[] charClass = { "Mage", "Warrior", "Nun" };
            comboBoxCharClass.Items.Add(charClass[0]);
            comboBoxCharClass.Items.Add(charClass[1]);
            comboBoxCharClass.Items.Add(charClass[2]);






        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();// Closes the app entirely            
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            if (textBoxCharFirstName.Text != "")// Has text?
            {
                StreamWriter sWriter = new StreamWriter(textBoxCharFirstName.Text);// Init
                string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);// Set save dir
                strPath = strPath + "/Character Config.txt";// Set save file name

                using (sWriter = File.AppendText(strPath)) sWriter.Write(textBoxCharFirstName.Text + Environment.NewLine);// Write text to file
                 
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

            int subTotal =  randNum1 + randNum2 + randNum3;// Subtotal of all randomly generated numbers
            int overage = 0;// Var

            if (subTotal > 20)// Random value total is over 20?
            {
                overage = subTotal - 20;
            }

            int trimAmt = overage / 3;// How much to trim from each random number
            int remainder = overage % 3;// Remainder after division

            /* Subtract trimAmt from each random number */
            randNum1 -= trimAmt;
            randNum2 -= trimAmt;
            randNum3 -= trimAmt;

            if (remainder > 0)// Could be between 0-2
            {
                int statToAdjust = GetRandNum(1, 3);// Get random number between 1 and 3

                /* Trim random stat */
                switch (statToAdjust)
                {
                    case 0:
                        break;
                    case 1:
                        randNum1 = randNum1 -= remainder;
                        break;
                    case 2:
                        randNum2 = randNum2 -= remainder;
                        break;
                    case 3:
                        randNum3 = randNum3 -= remainder;
                        break;
                    default:
                        break;
                }
            }

            /* Display random stat results */
            if (randNum1 > 10)
            {
                textBoxStatStr.Text = "10";
                trackBarStrength.Value = 10;
            }
            else
            {
                textBoxStatStr.Text = randNum1.ToString();
                trackBarStrength.Value = randNum1;
            }

            /* Catch out of range */
            if (randNum2 > 10)
            {
                textBoxStatInt.Text = "10";
                trackBarInt.Value = 10;
            }
            else
            {
                textBoxStatInt.Text = randNum2.ToString();
                trackBarInt.Value = randNum2;
            }

            if (randNum3 > 10)
            {
                textBoxStatStam.Text = "10";
                trackBarStam.Value = 10;
            }
            else
            {
                textBoxStatStam.Text = randNum3.ToString();
                trackBarStam.Value = randNum3;
            }               
        }

        private int GetRandNum(int r1, int r2)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());// Declare
           int randNum = random.Next(r1, r2);// Get rand in range

            return randNum;// Return int
        }

        int statStrNum = 0;
        int statIntNum = 0;
        int statStamNum = 0;

        private void trackBarStrength_Scroll(object sender, EventArgs e)
        {
            textBoxStatStr.Text = trackBarStrength.Value.ToString();
            int statStr = Int32.Parse(trackBarStrength.Value.ToString());

            if (statStr > statStrNum)// Did value increase?
            {
                CheckOverage("Strength");
            }
           statStrNum = statStr;// Assign new value to var
        }

        private void trackBarInt_Scroll(object sender, EventArgs e)
        {
            textBoxStatInt.Text = trackBarInt.Value.ToString();
            int statInt = Int32.Parse(trackBarInt.Value.ToString());

            if (statInt > statIntNum)
            {
                CheckOverage("Intelligence");
            }
            statIntNum = statInt;// Assign new value to var
        }

        private void trackBarStam_Scroll(object sender, EventArgs e)
        {
            textBoxStatStam.Text = trackBarStam.Value.ToString();
            int statStam = Int32.Parse(trackBarStam.Value.ToString());

            if (statStam > statStamNum)
            {
                CheckOverage("Stamina");
            }
            statStamNum = statStam;// Assign new value to var
        }

        private void CheckOverage(string stat)// Gets value over max of 20 points
        {
            int subTotal = 0;
            int str = Int32.Parse(textBoxStatStr.Text);
            int intel = Int32.Parse(textBoxStatInt.Text); 
            int stam = Int32.Parse(textBoxStatStam.Text);
            int overage = 0;

            subTotal = str + intel + stam;

            if (subTotal > 20)// Random value total is over 20?
            {
                overage = subTotal - 20;           

                int trimAmt = overage / 2;// How much to trim from each random number
                int remainder = overage % 2;// Remainder after division

                switch (stat)
                {
                    case "Strength":
                        intel -= trimAmt;// Trims overage / 2
                        stam -= trimAmt;// Trims overage / 2 
                        if (remainder > 0)
                        {
                            int randNum = GetRandNum(0, 100);// Get random number
                            if (randNum > 50)// Random num > 50?
                            {
                                intel -= remainder;// Set trimmed value
                            }
                            else
                            {
                                stam -= remainder;// Set trimmed value
                            }                            
                        }                   
                        break;
                    case "Intelligence":
                        str -= trimAmt;// Trims overage / 2
                        stam -= trimAmt;// Trims overage / 2 
                        if (remainder > 0)// Random num > 50?
                        {
                            int randNum = GetRandNum(0, 100);// Get random number
                            if (randNum > 50)
                            {
                                str -= remainder;// Set trimmed value
                            }
                            else
                            {
                                stam -= remainder;// Set trimmed value
                            }                            
                        }
                        break;
                    case "Stamina":
                        str -= trimAmt;// Trims overage / 2
                        intel -= trimAmt;// Trims overage / 2 
                        if (remainder > 0)// Random num > 50?
                        {
                           int randNum = GetRandNum(0, 100);// Get random number
                            if (randNum > 50)
                            {
                                str -= remainder;// Set trimmed value
                            }
                            else
                            {
                                intel -= remainder;// Set trimmed value
                            }                            
                        }
                        break;                 
                    default:
                        break;
                }
            }

            /* Populate textboxes and assign slider values */
            textBoxStatStr.Text = str.ToString();
            trackBarStrength.Value = str;

            textBoxStatInt.Text = intel.ToString();
            trackBarInt.Value = intel;

            textBoxStatStam.Text = stam.ToString();
            trackBarStam.Value = stam; 
        }

        private void buttonRandomizeBio_Click(object sender, EventArgs e)
        {
            /* Name arrays */
            string[] firstNameArr = { "Alexia", "Lauren ", "Esme " };
            string[] lastNameArr = { "Beasley ", "Beard", "Sanford" };

            string firstName;
            string lastName;
            
            /* Get random number */
            int r1 = GetRandNum(0, 2);
            int r2 = GetRandNum(0, 2);

            /* Assign random number to array index */
            firstName = firstNameArr[r1];
            lastName = lastNameArr[r2]; 

            /* Populate text */
            string fullName = firstName + " " + lastName;// Concat
            textBoxSummaryCharName.Text = fullName;

            /* Populate name in textboxes */
            textBoxCharFirstName.Text = firstName;
            textBoxCharLastName.Text = lastName;
        }
    }
}
