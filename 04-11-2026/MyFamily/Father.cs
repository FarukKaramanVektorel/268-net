using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamily
{
    internal class Father : FamilyMember
    {
        public Father(string name) : base(name)
        {
        }

        public override void React(DateTime time)
        {
            if (time.Hour > 22)
            {
                Console.WriteLine($"{Name} TVden başını kaldırıp nerdesin lan bu saate kadar diyor");
            }
            else if (time.Hour < 8)
            {
                Console.WriteLine($"{Name} bezbol sopası ile kapıya kadar kovalıyor");
            }
            else
            {
                Console.WriteLine($"{Name} niye geldin dedi...");
            }
        }
    }
}
