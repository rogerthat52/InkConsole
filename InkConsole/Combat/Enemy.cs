using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkConsole.Combat
{
    class Enemy : BaseCharacter
    {
        public Enemy()
        {
            this.HP = 50;
            this.Moveset = new List<Move> { new Move(15) };
        }
    }
}
