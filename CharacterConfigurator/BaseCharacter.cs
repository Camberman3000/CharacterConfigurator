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
        public string[] armor;
        public string[] weapons;

    }
}
