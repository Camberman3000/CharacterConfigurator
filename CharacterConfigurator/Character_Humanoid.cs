using System;
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
        public Character_Humanoid(List<string> armor, List<string> weapons) : base(armor, weapons)
        {
            /* Human-Specific gear */
            armor.Add("Chain Mail");
            armor.Add("Plate Mail");

            weapons.Add("Club");
            weapons.Add("Mace");           
        }
    }
}
