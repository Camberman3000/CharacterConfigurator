using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterConfigurator
{
    internal class BaseCharacter
    {
       public int strengthLimit = 0;
       public int intelligenceLimit = 0;
       public int staminaLimit = 0;

        /* Watch video to see how to pass data from base class to inherited classes
         * I want to have some armor and weapons that both classes can use, so the arrays will be prepopulated with some data */
        public string[] armorArr = new string[2];// New array with 2 entries
         
        List<string> weaponsList = new List<string>();// New empty list       

        /* Constructor */
        public BaseCharacter(int strengthLimit, int intelligenceLimit, int staminaLimit, string[] armor, List<string> weapons)
        {
            this.strengthLimit = strengthLimit;
            this.intelligenceLimit = intelligenceLimit;
            this.staminaLimit = staminaLimit;
            this.armorArr = armor;
            this.weaponsList = weapons;

            
            armor[0] = "cloth";
            armor[1] = "leather";
            

            weapons.Add("fists");
            weapons.Add("stick");
        }
    }
}
