using System;
using System.Collections.Generic;
using System.Text;

namespace WarCharacter
{
    internal class Warior
    {
        public Warior(string name, Nation nation)
        {
            Healt = 100;
            Energy = 80;
            Name = name;
            Nation = nation;
        }
        public double Healt { get; set; }
        public double Energy { get; set; }
        public string Name { get; set; }
        public Nation Nation { get; set; }
        public virtual double Attack()
        {
           return Nation.Power*Energy* 0.04;
        }
        public virtual void  TakeDamage(double attacked)
        {
            Healt -= attacked;
            Energy-= attacked*1.1;
        }

        public override string ToString()
        {
            return $"{Name} {Healt:F2} {Energy:F2} {Nation.Name}";
        }
       

    }
}
