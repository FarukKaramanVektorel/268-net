using System;
using System.Collections.Generic;
using System.Text;

namespace WarCharacter
{
    internal class Archer : Warior
    {
        public Archer(string name, Nation nation) : base(name, nation)
        {
            Healt = 70;
            Energy = 120;
        }

        public sealed override double Attack()
        {
            return base.Attack()*0.5;
        }

        public override void TakeDamage(double attacked)
        {
            Healt -= attacked*1.1;
            Energy -= attacked * 1.3;
        }
    
    
    }
}
