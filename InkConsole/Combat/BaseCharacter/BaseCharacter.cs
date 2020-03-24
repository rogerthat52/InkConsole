using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkConsole.Combat
{
    abstract class BaseCharacter
    {
        public int HP;
        protected List<Move> Moveset;

        public bool Alive {
            get {
                if(HP > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
