using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterConfigurator
{
    internal class BaseCharacter
    {
        /* Base class vars */
       public int strengthLimit = 0;
       public int intelligenceLimit = 0;
       public int staminaLimit = 0;
         
       List<string> armorList = new List<string>();// New empty armor list 
       List<string> weaponsList = new List<string>();// New empty weapon list       

        /* Constructor */
        public BaseCharacter(int strengthLimit, int intelligenceLimit, int staminaLimit, List<string> armor, List<string> weapons)
        {
            /* Assign var values */
            this.strengthLimit = strengthLimit;
            this.intelligenceLimit = intelligenceLimit;
            this.staminaLimit = staminaLimit;
            this.armorList = armor;            
            this.weaponsList = weapons;
           
            /* Populate items common to all child classes */
            armor.Add("Cloth");
            armor.Add("Leather");            

            weapons.Add("Fists");
            weapons.Add("Stick");
        }
    }
}
