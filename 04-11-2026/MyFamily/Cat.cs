using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamily
{
    internal class Cat : FamilyMember
    {
        public Cat(string name) : base(name)
        {
        }


       

        public override void React(DateTime time)
        {
            Console.WriteLine($"{Name} mama kabından kafasını kaldırmadı");
        }
    }
}
