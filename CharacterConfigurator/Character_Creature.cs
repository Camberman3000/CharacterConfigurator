using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterConfigurator
{
    internal class Character_Creature : BaseCharacter // Inherits from BaseCharacter
    {
        // Armor and Weapon types go here. This data will be used to populate combobox lists of available armor & weapons
        public Character_Creature(List<string> armor, List<string> weapons) : base(armor, weapons)
        {
            /* Creature-Specific gear - Added to base class items */
            armor.Add("Pearly Chitin");
            armor.Add("Thick Barnacle");

            weapons.Add("Sword");
            weapons.Add("Staff");


            //for (int i = 0; i < weapons.Count; i++)
            //{
            //    MessageBox.Show("CREATURE CLASS weapons: " + weapons[i].ToString());
            //}

            //for (int i = 0; i < armor.Count; i++)
            //{
            //    MessageBox.Show("CREATURE CLASS armor: " + armor[i].ToString());
            //}
        }
    }
}
