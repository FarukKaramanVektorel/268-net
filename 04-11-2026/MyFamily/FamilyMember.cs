using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamily
{
    internal abstract class FamilyMember
    {
      

        public string Name { get; set; }
        public FamilyMember(string name)
        {
            Name = name;
        }

        public abstract void React(DateTime time);

    }
}
