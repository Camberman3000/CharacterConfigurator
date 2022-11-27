using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterConfigurator
{
    internal class Character_Creature : BaseCharacter // Inherits from BaseCharacter
    {
        // Armor and Weapon types go here. This data will be used to populate combobox lists of available armor & weapons
        public Character_Creature(int strengthLimit, int intelligenceLimit, int staminaLimit, string[] armor, List<string> weapons) : base(strengthLimit, intelligenceLimit, staminaLimit, armor, weapons)
        {

        }
    }
}
