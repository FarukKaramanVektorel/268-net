using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamily
{
    internal class Mother : FamilyMember
    {
        public Mother(string name) : base(name)
        {
        }

        public override void React(DateTime time)
        {
            if (time.Hour > 22)
            {
                Console.WriteLine($"{Name} terliği eline aldı ve bu saate kadar nerdesin dedi...");
            }else if(time.Hour <8)
            {
                Console.WriteLine($"{Name} terliği eline aldı fırlattı, bu saate kadar nerdeysen orda yatsaydın dedi...");
            }
            else
            {
                Console.WriteLine($"{Name} hoş geldin dedi...");
            }
        }
    }
}
