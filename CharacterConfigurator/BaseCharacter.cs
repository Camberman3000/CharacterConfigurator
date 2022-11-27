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
       List<string> armorList = new List<string>();// New empty armor list 
       List<string> weaponsList = new List<string>();// New empty weapon list       

        /* Constructor */
        public BaseCharacter(List<string> armor, List<string> weapons)
        {
            /* Assign var values */          
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
