using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamily
{
    internal class Sister : FamilyMember
    {
        public Sister(string name) : base(name)
        {
        }

        public override void React(DateTime time)
        {
            if (time.Hour > 22)
            {
                Console.WriteLine($"{Name} fısıltıyla abi bana cips aldın mı");
            }
            else if (time.Hour < 8)
            {
                Console.WriteLine($"{Name} uyuyor...");
            }
            else
            {
                Console.WriteLine($"{Name} abi dondurma yemeye gidelim mi");
            }
        }
    }
}
