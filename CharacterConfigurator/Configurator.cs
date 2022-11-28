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
            cbHometown.Items.Add("Deep Glen");
            cbHometown.Items.Add("Rocky Nock");
            cbHometown.Items.Add("Hill Valley");
            cbHometown.Items.Add("Black Bend");
            cbHometown.Items.Add("Party City");
            cbHometown.Items.Add("Dooferville");

            /* Add combobox text via array index */
            string[] charClass = { "Mage", "Warrior", "Nun", "Ranger", "Barbarian", "Cleric" };
            cbCharClass.Items.Add(charClass[0]);
            cbCharClass.Items.Add(charClass[1]);
            cbCharClass.Items.Add(charClass[2]);
            cbCharClass.Items.Add(charClass[3]);
            cbCharClass.Items.Add(charClass[4]);
            cbCharClass.Items.Add(charClass[5]);

            tbCharFirstName.Select();// Put focus in first textbox

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();// Closes the app entirely            
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            if (tbCharFirstName.Text != "")// Has text?
            {
                // TODO: Delete all text in file and write new data (Add an if statement to warn user if character isn't completely filled out)
                StreamWriter sWriter = new StreamWriter(tbCharFirstName.Text);// Init
                string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);// Set save dir
                strPath = strPath + "/Character Config.txt";// Set save file name

                using (sWriter = File.AppendText(strPath)) sWriter.Write(tbCharFirstName.Text + Environment.NewLine);// Write text to file
                 
                sWriter.Close();// Close writer
                MessageBox.Show("Character saved!", "Success", MessageBoxButtons.OK);// Notify user
            }
            else
            {
                MessageBox.Show("Nothing to save. Please create a character first.", "No data", MessageBoxButtons.OK);// Show error msg
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
                tbStatStr.Text = "10";
                trackBarStrength.Value = 10;
            }
            else
            {
                tbStatStr.Text = randNum1.ToString();
                trackBarStrength.Value = randNum1;
            }

            /* Catch out of range */
            if (randNum2 > 10)
            {
                tbStatInt.Text = "10";
                trackBarInt.Value = 10;
            }
            else
            {
                tbStatInt.Text = randNum2.ToString();
                trackBarInt.Value = randNum2;
            }

            if (randNum3 > 10)
            {
                tbStatStam.Text = "10";
                trackBarStam.Value = 10;
            }
            else
            {
                tbStatStam.Text = randNum3.ToString();
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
            tbStatStr.Text = trackBarStrength.Value.ToString();
            int statStr = Int32.Parse(trackBarStrength.Value.ToString());

            if (statStr > statStrNum)// Did value increase?
            {
                CheckOverage("Strength");
            }
            statStrNum = statStr;// Assign new value to var
            tbSummaryStr.Text = statStrNum.ToString();// Set summary text
        }

        private void trackBarInt_Scroll(object sender, EventArgs e)
        {
            tbStatInt.Text = trackBarInt.Value.ToString();
            int statInt = Int32.Parse(trackBarInt.Value.ToString());

            if (statInt > statIntNum)
            {
                CheckOverage("Intelligence");
            }
            statIntNum = statInt;// Assign new value to var
            tbSummaryInt.Text = statIntNum.ToString();// Set summary text
        }

        private void trackBarStam_Scroll(object sender, EventArgs e)
        {
            tbStatStam.Text = trackBarStam.Value.ToString();
            int statStam = Int32.Parse(trackBarStam.Value.ToString());

            if (statStam > statStamNum)
            {
                CheckOverage("Stamina");
            }
            statStamNum = statStam;// Assign new value to var
            tbSummaryStam.Text = statStamNum.ToString();// Set summary text
        }

        private void CheckOverage(string stat)// Gets value over max of 20 points
        {
            int subTotal = 0;
            int str = Int32.Parse(tbStatStr.Text);
            int intel = Int32.Parse(tbStatInt.Text); 
            int stam = Int32.Parse(tbStatStam.Text);
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

            /* Populate textboxes and assign slider values and summary text */
            tbStatStr.Text = str.ToString();
            trackBarStrength.Value = str;
            tbSummaryStr.Text = str.ToString();

            tbStatInt.Text = intel.ToString();
            trackBarInt.Value = intel;
            tbSummaryInt.Text = intel.ToString();

            tbStatStam.Text = stam.ToString();
            trackBarStam.Value = stam;
            tbSummaryStam.Text = stam.ToString();
        }

        private void buttonRandomizeBio_Click(object sender, EventArgs e)
        {
            /* Name arrays */
            string[] firstNameArr = { "Alexia", "Lauren ", "Esme ", "Saylah ", "Oran ", "Mahle ", "Wiseco ", "Milodon " };
            string[] lastNameArr = { "Beasley ", "Beard", "Sanford", "Tang", "Slade", "Baker", "Smith" };

            string firstName;
            string lastName;
            
            /* Get random number */
            int r1 = GetRandNum(0, firstNameArr.Length);
            int r2 = GetRandNum(0, lastNameArr.Length);

            /* Assign random number to array index */
            firstName = firstNameArr[r1];
            lastName = lastNameArr[r2]; 

            /* Populate text */
            string fullName = firstName + " " + lastName;// Concat
            tbSummaryCharName.Text = fullName;

            /* Populate Summary data */
            tbCharFirstName.Text = firstName;
            tbCharLastName.Text = lastName;

            int r3 = GetRandNum(0, cbHometown.Items.Count - 1);
            cbHometown.SelectedIndex = r3;
            tbSummaryHomeTown.Text = cbHometown.SelectedItem.ToString();

            int r4 = GetRandNum(0, cbCharClass.Items.Count - 1);
            cbCharClass.SelectedIndex = r4;
            tbSummaryCharClass.Text = cbCharClass.SelectedItem.ToString();

            tbSummaryStr.Text = tbStatStr.Text;
            tbSummaryInt.Text = tbStatInt.Text;
            tbSummaryStam.Text = tbStatStam.Text;

            int r5 = GetRandNum(0, 100);
            int r5a = r5 % 2;

            if (r5a == 0)
            {
                rb_Humanoid.Checked = true;
            }
            else
            {
                rb_Creature.Checked = true;
            }

            if (rb_Humanoid.Checked)
            {
                tbSummaryCharRace.Text = "Humanoid";
            }
            else if (rb_Creature.Checked)
            {
                tbSummaryCharRace.Text = "Creature";
            }
        }

        private void RandomizeCharacter()
        {
            GetRandomBio();

            GetRandomStats();

            GetRandomGear();
        }

        private void GetRandomBio()
        {
            /* Name arrays */
            string[] firstNameArr = { "Alexia", "Lauren ", "Esme ", "Saylah ", "Oran ", "Mahle ", "Wiseco ", "Milodon " };
            string[] lastNameArr = { "Beasley ", "Beard", "Sanford", "Tang", "Slade", "Baker", "Smith" };

            string firstName;
            string lastName;

            /* Get random number */
            int r1 = GetRandNum(0, firstNameArr.Length);
            int r2 = GetRandNum(0, lastNameArr.Length);

            /* Assign random number to array index */
            firstName = firstNameArr[r1];
            lastName = lastNameArr[r2];

            /* Populate summary text */
            string fullName = firstName + " " + lastName;// Concat
            tbSummaryCharName.Text = fullName;

            /* Populate Summary data */
            tbCharFirstName.Text = firstName;
            tbCharLastName.Text = lastName;

            int r3 = GetRandNum(0, cbHometown.Items.Count - 1);
            cbHometown.SelectedIndex = r3;
            tbSummaryHomeTown.Text = cbHometown.SelectedItem.ToString();

            int r4 = GetRandNum(0, cbCharClass.Items.Count - 1);
            cbCharClass.SelectedIndex = r4;
            tbSummaryCharClass.Text = cbCharClass.SelectedItem.ToString();
                     
            int r5 = GetRandNum(0, 100);// Get random number
            int r5a = r5 % 2;// Get remainder, checking for even/odd

            if (r5a == 0)// Is even?
            {
                rb_Humanoid.Checked = true;
                tbSummaryCharRace.Text = "Humanoid";
            }
            else
            {
                rb_Creature.Checked = true;
                tbSummaryCharRace.Text = "Creature";
            }

            //if (rb_Humanoid.Checked)
            //{
            //    tbSummaryCharRace.Text = "Humanoid";
            //}
            //else if (rb_Creature.Checked)
            //{
            //    tbSummaryCharRace.Text = "Creature";
            //}
        }

        private void GetRandomStats()
        {
            /* Get random number between 10-20 */
            int randNum1 = GetRandNum(10, 20);
            int randNum2 = GetRandNum(10, 20);
            int randNum3 = GetRandNum(10, 20);

            int subTotal = randNum1 + randNum2 + randNum3;// Subtotal of all randomly generated numbers
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
                tbStatStr.Text = "10";
                trackBarStrength.Value = 10;
            }
            else
            {
                tbStatStr.Text = randNum1.ToString();
                trackBarStrength.Value = randNum1;
            }

            /* Catch out of range */
            if (randNum2 > 10)
            {
                tbStatInt.Text = "10";
                trackBarInt.Value = 10;
            }
            else
            {
                tbStatInt.Text = randNum2.ToString();
                trackBarInt.Value = randNum2;
            }

            if (randNum3 > 10)
            {
                tbStatStam.Text = "10";
                trackBarStam.Value = 10;
            }
            else
            {
                tbStatStam.Text = randNum3.ToString();
                trackBarStam.Value = randNum3;
            }

            /* Populate summary boxes */
            tbSummaryStr.Text = tbStatStr.Text;
            tbSummaryInt.Text = tbStatInt.Text;
            tbSummaryStam.Text = tbStatStam.Text;
        }

        private void GetRandomGear()
        {
            /* Random number between index 0 and last index */
            int r1 = GetRandNum(0, cbArmor.Items.Count);
            int r2 = GetRandNum(0, cbWeapon.Items.Count);
            
            /* Set combobox to the random index */
            cbArmor.SelectedIndex = r1;
            cbWeapon.SelectedIndex = r2;

            /* Set summary text */
            tbSummaryArmor.Text = cbArmor.SelectedItem.ToString();
            tbSummaryWeapon.Text = cbWeapon.SelectedItem.ToString();
        }

        private void flp_Bio_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flp_Bio.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void flp_Stats_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flp_Stats.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void flp_Summary_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.flp_Summary.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void rb_Humanoid_CheckedChanged(object sender, EventArgs e)
        {            
            if (rb_Humanoid.Checked)// User checked Humanoid rb?
            {                
                HumanoidSelected();// Randomize chosen - Don't ask for confirmation              
            }                         
        }        

        private void HumanoidSelected()
        {
            tbGearClass.Text = "Humanoid";
            tbSummaryCharRace.Text = "Humanoid";

            List<string> armor = new List<string>();
            List<string> weapons = new List<string>();// New empty list   

            Character_Humanoid charHuman = new Character_Humanoid(armor, weapons);// Declare new humanoid
            cbArmor.Items.Clear();// Clear list before populating with data
            cbArmor.SelectedIndex = -1;// Set selection to null
            tbSummaryArmor.Text = "";// Clear summary
            for (int i = 0; i < armor.Count; i++)// Loop through armor list
            {
                cbArmor.Items.Add(armor[i].ToString());// Add selection to combobox
            }

            cbWeapon.Items.Clear();// Clear list before populating with data
            cbWeapon.SelectedIndex = -1;// Set selection to null
            tbSummaryWeapon.Text = "";// Clear summary
            for (int i = 0; i < weapons.Count; i++)// Loop through armor list
            {
                cbWeapon.Items.Add(weapons[i].ToString());// Add selection to combobox
            }
        }

        private void rb_Creature_CheckedChanged(object sender, EventArgs e)
        {                  
            if (rb_Creature.Checked)
            {                   
                CreatureSelected();// Randomize chosen - Don't ask for confirmation                
            }                          
        }

        private void CreatureSelected()
        {
            tbGearClass.Text = "Creature";
            tbSummaryCharRace.Text = "Creature";

            List<string> armor = new List<string>();
            List<string> weapons = new List<string>();// New empty list   

            Character_Creature charCreature = new Character_Creature(armor, weapons);// Declare new creature
            cbArmor.Items.Clear();// Clear list before populating with data
            cbArmor.SelectedIndex = -1;// Set selection to null
            tbSummaryArmor.Text = "";// Clear summary
            for (int i = 0; i < armor.Count; i++)// Loop through armor list
            {
                cbArmor.Items.Add(armor[i].ToString());// Add selection to combobox
            }

            cbWeapon.Items.Clear();// Clear list before populating with data
            cbWeapon.SelectedIndex = -1;// Set selection to null
            tbSummaryWeapon.Text = "";// Clear summary
            for (int i = 0; i < weapons.Count; i++)// Loop through armor list
            {
                cbWeapon.Items.Add(weapons[i].ToString());// Add selection to combobox
            }
        }

        private void btnRandomizeChar_Click(object sender, EventArgs e)
        {             
            RandomizeCharacter();
        }

        private void cbArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSummaryArmor.Text = cbArmor.SelectedItem.ToString();// Populate summary text
        }

        private void cbWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSummaryWeapon.Text = cbWeapon.SelectedItem.ToString();// Populate summary text
        }

        private void tbCharFirstName_TextChanged(object sender, EventArgs e)
        {
            tbSummaryCharName.Text = tbCharFirstName.Text + " " + tbCharLastName.Text;// Populate summary text
        }

        private void tbCharLastName_TextChanged(object sender, EventArgs e)
        {
            tbSummaryCharName.Text = tbCharFirstName.Text + " " + tbCharLastName.Text;// Populate summary text
        }

        private void cbHometown_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSummaryHomeTown.Text = cbHometown.SelectedItem.ToString();// Populate summary text
        }

        private void cbCharClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSummaryCharClass.Text = cbCharClass.SelectedItem.ToString();// Populate summary text
        }
    }
}
