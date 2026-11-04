using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSystem
{
    internal class Gorev
    {      

        public string Name { get; set; }
        public double KatSayi { get; set; }

        public Gorev(string name, double katSayi)
        {
            Name = name;
            KatSayi = katSayi;
        }
    }
}
