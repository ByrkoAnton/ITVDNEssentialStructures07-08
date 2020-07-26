using System;
using System.Collections.Generic;
using System.Text;

namespace Structures02t03
{
    class Accauntant
    {
        public static bool AskForBonus(Positions pos, int hours)
        {
            if((int)pos<=hours)  
                return true;
            return false;
        }
    }
}
