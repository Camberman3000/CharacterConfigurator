﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterConfigurator
{
    internal class Character_Humanoid : BaseCharacter // Inherits from BaseCharacter
    {
        // Armor and Weapon types go here. This data will be used to populate combobox lists of available armor & weapons
        public Character_Humanoid(int strengthLimit, int intelligenceLimit, int staminaLimit, List<string> armor, List<string> weapons) : base(strengthLimit, intelligenceLimit, staminaLimit, armor, weapons)
        {
            for (int i = 0; i < weapons.Count; i++)
            {
                MessageBox.Show("HUMANOID CLASS weapons: " + weapons[i].ToString());
            }

            for (int i = 0; i < armor.Count; i++)
            {
                MessageBox.Show("HUMANOID CLASS armor: " + armor[i].ToString());
            }
        }
    }
}
